using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    internal class FilesMenu
    {
        private List<TabInfo> openedFiles;
        private List<int> usedUntitledNums;
        private int untitledCount;
        private TabControl tabControl1;

        public FilesMenu(TabControl tabControl)
        {
            openedFiles = new List<TabInfo>();
            usedUntitledNums = new List<int>();
            untitledCount = 0;
            tabControl1 = tabControl;
        }

        private void MarkAsUnsaved()
        {
            TabPage selectedTab = tabControl1.SelectedTab;
            var tabInfo = openedFiles.FirstOrDefault(t => t.TabPage == selectedTab);
            tabInfo.IsSaved = false;
            if (!selectedTab.Text.EndsWith("*"))
            {
                selectedTab.Text = selectedTab.Text + "  *";
            }
        }

        public void TextBoxChange(object sender, EventArgs e)
        {
            MarkAsUnsaved();
        }

        public void NewFile()
        {
            int newUntitledNumber = untitledCount;

            if (usedUntitledNums.Count > 0)
            {

                for (int i = 0; i <= usedUntitledNums.Count + 1; i++)
                {
                    if (!usedUntitledNums.Contains(i))
                    {
                        newUntitledNumber = i;
                        break;
                    }
                }
            }
            string newFileName = $"Untitled file {newUntitledNumber}  *";
            TabPage tabPage = new TabPage(newFileName);
            TextBox textBox = new TextBox()
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Microsoft Sans Serif", 11F),
                Dock = DockStyle.Fill,
                AcceptsTab = true
            };
            textBox.TextChanged += new EventHandler(TextBoxChange);
            tabPage.Controls.Add(textBox);
            this.tabControl1.TabPages.Add(tabPage);
            this.tabControl1.Visible = true;

            openedFiles.Add(new TabInfo
            {
                TabPage = tabPage,
                IsSaved = false,
                UntitledNumber = newUntitledNumber,
                FilePath = ""
            });
            usedUntitledNums.Add(newUntitledNumber);
            untitledCount++;
        }

        public void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    TabPage tabPage = new TabPage(Path.GetFileNameWithoutExtension(filePath));
                    TextBox textBox = new TextBox()
                    {
                        Multiline = true,
                        ScrollBars = ScrollBars.Vertical,
                        Font = new Font("Microsoft Sans Serif", 11F),
                        Dock = DockStyle.Fill,
                        AcceptsTab = true,
                        Text = File.ReadAllText(filePath)
                    };

                    textBox.TextChanged += new EventHandler(TextBoxChange);
                    tabPage.Controls.Add(textBox);
                    this.tabControl1.TabPages.Add(tabPage);
                    this.tabControl1.Visible = true;
                    this.tabControl1.SelectedTab = tabPage;

                    openedFiles.Add(new TabInfo
                    {
                        TabPage = tabPage,
                        IsSaved = true,
                        UntitledNumber = -1,
                        FilePath = filePath

                    });
                }
            }
        }
        // check empty selected tab exception handling
        // add message when closing if file is not saved
        public void CloseFile()
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("No open files found");
                return;
            }
            TabPage selectedTab = tabControl1.SelectedTab;
            var tabInfo = openedFiles.FirstOrDefault(t => t.TabPage == selectedTab);

            if (!tabInfo.IsSaved)
            {
                var result = MessageBox.Show("There are unsaved changes. Do you want to save current file?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else
                {
                    untitledCount--;
                    usedUntitledNums.Remove(tabInfo.UntitledNumber);
                }
            }

            tabControl1.TabPages.Remove(selectedTab);
            openedFiles.Remove(tabInfo);



            if (tabControl1.TabPages.Count == 0)
            {
                tabControl1.Visible = false;
                return;
            }
        }
        public void CloseAllFiles()
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("No open files found");
                return;
            }
            foreach (TabInfo tabInfo in openedFiles)
            {
                if (!tabInfo.IsSaved)
                {
                    var result = MessageBox.Show("There are unsaved changes. Do you want to still proceed?", "Unsaved changes", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        tabControl1.TabPages.Clear();
                        usedUntitledNums.Clear();
                        openedFiles.Clear();
                        untitledCount = 0;
                        tabControl1.Visible = false;
                        return;
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }

                }
            }
        }

        public void SaveFile()
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("No opened files found");
                return;
            }
            TabPage selectedTab = tabControl1.SelectedTab;
            var tabInfo = openedFiles.FirstOrDefault(t => t.TabPage == selectedTab);

            if (!tabInfo.IsSaved)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                    if (tabInfo.UntitledNumber == -1)
                    {
                        File.WriteAllText(tabInfo.FilePath, selectedTab.Controls[0].Text);
                        tabInfo.IsSaved = true;
                        selectedTab.Text = selectedTab.Text.Substring(0, selectedTab.Text.Length - 3);
                    }
                    else
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            tabInfo.FilePath = filePath;
                            usedUntitledNums.Remove(tabInfo.UntitledNumber);
                            tabInfo.UntitledNumber = -1;
                            untitledCount--;
                            File.WriteAllText(tabInfo.FilePath, selectedTab.Controls[0].Text);
                            tabInfo.IsSaved = true;
                            selectedTab.Text = Path.GetFileNameWithoutExtension(tabInfo.FilePath);

                        }
                    }
                };
            }

        }

        public void SaveFileAs()
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("No opened files found");
                return;
            }
            TabPage selectedTab = tabControl1.SelectedTab;
            var tabInfo = openedFiles.FirstOrDefault(t => t.TabPage == selectedTab);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (tabInfo.UntitledNumber == -1)
                    {
                        string filePath = saveFileDialog.FileName;
                        tabInfo.FilePath = filePath;
                        File.WriteAllText(tabInfo.FilePath, selectedTab.Controls[0].Text);
                        tabInfo.IsSaved = true;
                        selectedTab.Text = Path.GetFileNameWithoutExtension(tabInfo.FilePath);
                    }
                    else
                    {
                        string filePath = saveFileDialog.FileName;
                        tabInfo.FilePath = filePath;
                        usedUntitledNums.Remove(tabInfo.UntitledNumber);
                        tabInfo.UntitledNumber = -1;
                        untitledCount--;
                        File.WriteAllText(tabInfo.FilePath, selectedTab.Controls[0].Text);
                        tabInfo.IsSaved = true;
                        selectedTab.Text = Path.GetFileNameWithoutExtension(tabInfo.FilePath);
                    }
                }
            };
        }
        public void SaveAllFiles()
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("No open files found");
                return;
            }
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                var currTabInfo = openedFiles.FirstOrDefault(t => t.TabPage == tabPage);
                if (!currTabInfo.IsSaved && currTabInfo.UntitledNumber == -1)
                {
                    File.WriteAllText(currTabInfo.FilePath, tabPage.Controls[0].Text);
                    currTabInfo.IsSaved = true;
                    tabPage.Text = tabPage.Text.Substring(0, tabPage.Text.Length - 3);
                }
            }
        }
    }
}
