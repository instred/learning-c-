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
        private FilesMenu filesMenu;
        
        public Form1()
        {
            InitializeComponent();
            filesMenu = new FilesMenu(tabControl1);

        }


        private void ButtonNewFile_Click(object sender, EventArgs e)
        {
            filesMenu.NewFile();
        }
        private void MenuNewFile_Click(object sender, EventArgs e)
        {
            filesMenu.NewFile();
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            filesMenu.OpenFile();
        }

        private void MenuOpenFile_Click(object sender, EventArgs e)
        {
            filesMenu.OpenFile();
        }

        private void MenuExitProgram_Click(object sender, EventArgs e)
        {
            // add info if there is any file not saved
            Application.Exit();
        }

        private void ButtonCloseFile_Click(object sender, EventArgs e)
        {
            filesMenu.CloseFile();
        }

        private void MenuCloseFile_Click(object sender, EventArgs e)
        {
            filesMenu.CloseFile();
        }
        private void ButtonCloseAll_Click(object sender, EventArgs e)
        {
            filesMenu.CloseAllFiles();
        }
        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            filesMenu.SaveFile();
        }

        private void MenuSaveFile_Click(object sender, EventArgs e)
        {
            filesMenu.SaveFile();
        }

        private void MenuSaveAs_Click(object sender, EventArgs e)
        {
            filesMenu.SaveFileAs();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            filesMenu.SaveAllFiles();
        }


    }
}
