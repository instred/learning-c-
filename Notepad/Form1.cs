using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {

        private List<TabInfo> openedFiles = new List<TabInfo>();
        private List<int> usedUntitledNums = new List<int>();
        private int untitledCount = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void SaveFile(string filePath)
        {

        }

        private void RenderOpenedFiles()
        {

        }

        private void ButtonNewFile_Click(object sender, EventArgs e)
        {
            int newUntitledNumber = untitledCount;

            if (usedUntitledNums.Count > 0)
            {

                Console.WriteLine(usedUntitledNums.Count);
                for (int i = 0; i <= usedUntitledNums.Count + 1; i++)
                {
                    if (!usedUntitledNums.Contains(i))
                    {
                        newUntitledNumber = i;
                        break;
                    }
                }
            }
            string newFileName = $"Untitled file {newUntitledNumber}";
            TabPage tabPage = new TabPage(newFileName);
            TextBox textBox = new TextBox()
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Microsoft Sans Serif", 11F),
                Dock = DockStyle.Fill,
                AcceptsTab = true
            };
            tabPage.Controls.Add(textBox);
            this.tabControl1.TabPages.Add(tabPage);
            this.tabControl1.Visible = true;

            openedFiles.Add(new TabInfo
            {
                TabPage = tabPage,
                IsSaved = false,
                UntitledNumber = newUntitledNumber
            });
            usedUntitledNums.Add(newUntitledNumber);
            untitledCount++;
        }
        private void MenuNewFile_Click(object sender, EventArgs e)
        {
            int newUntitledNumber = untitledCount;

            if (usedUntitledNums.Count > 0)
            {

                Console.WriteLine(usedUntitledNums.Count);
                for (int i = 0; i <= usedUntitledNums.Count + 1; i++)
                {
                    if (!usedUntitledNums.Contains(i))
                    {
                        newUntitledNumber = i;
                        break;
                    }
                }
            }
            string newFileName = $"Untitled file {newUntitledNumber}";
            TabPage tabPage = new TabPage(newFileName);
            TextBox textBox = new TextBox()
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Microsoft Sans Serif", 11F),
                Dock = DockStyle.Fill,
                AcceptsTab = true
            };
            tabPage.Controls.Add(textBox);
            this.tabControl1.TabPages.Add(tabPage);
            this.tabControl1.Visible = true;

            openedFiles.Add(new TabInfo
            {
                TabPage = tabPage,
                IsSaved = false,
                UntitledNumber = newUntitledNumber
            });
            usedUntitledNums.Add(newUntitledNumber);
            untitledCount++;
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
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
                    tabPage.Controls.Add(textBox);
                    this.tabControl1.TabPages.Add(tabPage);
                    this.tabControl1.Visible = true;

                    openedFiles.Add(new TabInfo
                    {
                        TabPage = tabPage,
                        IsSaved = false
                        
                    });
                }
            }
        }

        private void MenuOpenFile_Click(object sender, EventArgs e)
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
                    tabPage.Controls.Add(textBox);
                    this.tabControl1.TabPages.Add(tabPage);
                    this.tabControl1.Visible = true;

                    openedFiles.Add(new TabInfo
                    {
                        TabPage = tabPage,
                        IsSaved = false
                    });
                }
            }
        }

        private void MenuExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCloseFile_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;
            var tabInfo = openedFiles.FirstOrDefault(t => t.TabPage == selectedTab);

            if (tabInfo != null)
            {
                if (!tabInfo.IsSaved)
                {
                    untitledCount--;
                    usedUntitledNums.Remove(tabInfo.UntitledNumber);
                }
                tabControl1.TabPages.Remove(selectedTab);
                openedFiles.Remove(tabInfo);
            }
        }

        private void MenuCloseFile_Click(object sender, EventArgs e)
        {

            TabPage selectedTab = tabControl1.SelectedTab;
            var tabInfo = openedFiles.FirstOrDefault(t => t.TabPage == selectedTab);

            if (tabInfo != null)
            {
                if (!tabInfo.IsSaved)
                {
                    untitledCount--;
                    usedUntitledNums.Remove(tabInfo.UntitledNumber);
                }
                tabControl1.TabPages.Remove(selectedTab);
                openedFiles.Remove(tabInfo);
            }
        }
    }
}
