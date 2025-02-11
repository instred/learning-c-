using System.Drawing;
using System.Windows.Forms;

namespace Notepad
{
    partial class Form1
    {

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.editDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFontSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFontFamily = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.buttonNewFile = new System.Windows.Forms.ToolStripButton();
            this.buttonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.buttonSaveFile = new System.Windows.Forms.ToolStripButton();
            this.buttonSaveAll = new System.Windows.Forms.ToolStripButton();
            this.buttonCloseFile = new System.Windows.Forms.ToolStripButton();
            this.buttonCloseAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonCut = new System.Windows.Forms.ToolStripButton();
            this.buttonCopy = new System.Windows.Forms.ToolStripButton();
            this.buttonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonUndo = new System.Windows.Forms.ToolStripButton();
            this.buttonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.buttonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDown,
            this.editDropDown,
            this.searchDropDown,
            this.menuFontSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1192, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolMenuText";
            // 
            // fileDropDown
            // 
            this.fileDropDown.AutoSize = false;
            this.fileDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileDropDown.DoubleClickEnabled = true;
            this.fileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewFile,
            this.menuOpenFile,
            this.menuSaveFile,
            this.menuSaveAs,
            this.menuCloseFile,
            this.menuExitProgram});
            this.fileDropDown.Image = ((System.Drawing.Image)(resources.GetObject("fileDropDown.Image")));
            this.fileDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileDropDown.Name = "fileDropDown";
            this.fileDropDown.Size = new System.Drawing.Size(80, 22);
            this.fileDropDown.Text = "File";
            this.fileDropDown.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // menuNewFile
            // 
            this.menuNewFile.Name = "menuNewFile";
            this.menuNewFile.Size = new System.Drawing.Size(224, 26);
            this.menuNewFile.Text = "New";
            this.menuNewFile.Click += new System.EventHandler(this.MenuNewFile_Click);
            // 
            // menuOpenFile
            // 
            this.menuOpenFile.Name = "menuOpenFile";
            this.menuOpenFile.Size = new System.Drawing.Size(224, 26);
            this.menuOpenFile.Text = "Open";
            this.menuOpenFile.Click += new System.EventHandler(this.MenuOpenFile_Click);
            // 
            // menuSaveFile
            // 
            this.menuSaveFile.Name = "menuSaveFile";
            this.menuSaveFile.Size = new System.Drawing.Size(224, 26);
            this.menuSaveFile.Text = "Save";
            this.menuSaveFile.Click += new System.EventHandler(this.MenuSaveFile_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(224, 26);
            this.menuSaveAs.Text = "Save As...";
            this.menuSaveAs.Click += new System.EventHandler(this.MenuSaveAs_Click);
            // 
            // menuCloseFile
            // 
            this.menuCloseFile.Name = "menuCloseFile";
            this.menuCloseFile.Size = new System.Drawing.Size(224, 26);
            this.menuCloseFile.Text = "Close";
            this.menuCloseFile.Click += new System.EventHandler(this.MenuCloseFile_Click);
            // 
            // menuExitProgram
            // 
            this.menuExitProgram.Name = "menuExitProgram";
            this.menuExitProgram.Size = new System.Drawing.Size(224, 26);
            this.menuExitProgram.Text = "Exit";
            this.menuExitProgram.Click += new System.EventHandler(this.MenuExitProgram_Click);
            // 
            // editDropDown
            // 
            this.editDropDown.AutoSize = false;
            this.editDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.menuRedo,
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.menuDelete,
            this.menuSelectAll});
            this.editDropDown.Image = ((System.Drawing.Image)(resources.GetObject("editDropDown.Image")));
            this.editDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editDropDown.Name = "editDropDown";
            this.editDropDown.Size = new System.Drawing.Size(80, 22);
            this.editDropDown.Text = "Edit";
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.Size = new System.Drawing.Size(154, 26);
            this.menuUndo.Text = "Undo";
            // 
            // menuRedo
            // 
            this.menuRedo.Name = "menuRedo";
            this.menuRedo.Size = new System.Drawing.Size(154, 26);
            this.menuRedo.Text = "Redo";
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.Size = new System.Drawing.Size(154, 26);
            this.menuCut.Text = "Cut";
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.Size = new System.Drawing.Size(154, 26);
            this.menuCopy.Text = "Copy";
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.Size = new System.Drawing.Size(154, 26);
            this.menuPaste.Text = "Paste";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(154, 26);
            this.menuDelete.Text = "Delete";
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Name = "menuSelectAll";
            this.menuSelectAll.Size = new System.Drawing.Size(154, 26);
            this.menuSelectAll.Text = "Select All";
            // 
            // searchDropDown
            // 
            this.searchDropDown.AutoSize = false;
            this.searchDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFind,
            this.menuReplace});
            this.searchDropDown.Image = ((System.Drawing.Image)(resources.GetObject("searchDropDown.Image")));
            this.searchDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchDropDown.Name = "searchDropDown";
            this.searchDropDown.Size = new System.Drawing.Size(80, 22);
            this.searchDropDown.Text = "Search";
            // 
            // menuFind
            // 
            this.menuFind.Name = "menuFind";
            this.menuFind.Size = new System.Drawing.Size(154, 26);
            this.menuFind.Text = "Find...";
            // 
            // menuReplace
            // 
            this.menuReplace.Name = "menuReplace";
            this.menuReplace.Size = new System.Drawing.Size(154, 26);
            this.menuReplace.Text = "Replace...";
            // 
            // menuFontSize
            // 
            this.menuFontSize.AutoSize = false;
            this.menuFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFontSize.DoubleClickEnabled = true;
            this.menuFontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem,
            this.menuFontFamily});
            this.menuFontSize.Image = ((System.Drawing.Image)(resources.GetObject("menuFontSize.Image")));
            this.menuFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFontSize.Name = "menuFontSize";
            this.menuFontSize.Size = new System.Drawing.Size(80, 22);
            this.menuFontSize.Text = "Text";
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // menuFontFamily
            // 
            this.menuFontFamily.Name = "menuFontFamily";
            this.menuFontFamily.Size = new System.Drawing.Size(167, 26);
            this.menuFontFamily.Text = "Font Family";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNewFile,
            this.buttonOpenFile,
            this.buttonSaveFile,
            this.buttonSaveAll,
            this.buttonCloseFile,
            this.buttonCloseAll,
            this.toolStripSeparator1,
            this.buttonCut,
            this.buttonCopy,
            this.buttonPaste,
            this.toolStripSeparator2,
            this.buttonUndo,
            this.buttonRedo,
            this.toolStripSeparator3,
            this.buttonFind,
            this.toolStripSeparator4,
            this.buttonZoomIn,
            this.buttonZoomOut});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1192, 28);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolMenuIcons";
            // 
            // buttonNewFile
            // 
            this.buttonNewFile.AutoSize = false;
            this.buttonNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNewFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewFile.Image")));
            this.buttonNewFile.ImageTransparentColor = System.Drawing.Color.Linen;
            this.buttonNewFile.Name = "buttonNewFile";
            this.buttonNewFile.Size = new System.Drawing.Size(25, 25);
            this.buttonNewFile.Text = "newFile";
            this.buttonNewFile.Click += new System.EventHandler(this.ButtonNewFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.AutoSize = false;
            this.buttonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(25, 25);
            this.buttonOpenFile.Text = "openFile";
            this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.AutoSize = false;
            this.buttonSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(25, 25);
            this.buttonSaveFile.Text = "saveFile";
            this.buttonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.AutoSize = false;
            this.buttonSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAll.Image")));
            this.buttonSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(25, 25);
            this.buttonSaveAll.Text = "saveAll";
            this.buttonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // buttonCloseFile
            // 
            this.buttonCloseFile.AutoSize = false;
            this.buttonCloseFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCloseFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseFile.Image")));
            this.buttonCloseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCloseFile.Name = "buttonCloseFile";
            this.buttonCloseFile.Size = new System.Drawing.Size(25, 25);
            this.buttonCloseFile.Text = "closeFile";
            this.buttonCloseFile.Click += new System.EventHandler(this.ButtonCloseFile_Click);
            // 
            // buttonCloseAll
            // 
            this.buttonCloseAll.AutoSize = false;
            this.buttonCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseAll.Image")));
            this.buttonCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCloseAll.Name = "buttonCloseAll";
            this.buttonCloseAll.Size = new System.Drawing.Size(25, 25);
            this.buttonCloseAll.Text = "closeAll";
            this.buttonCloseAll.Click += new System.EventHandler(this.ButtonCloseAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(25, 25);
            // 
            // buttonCut
            // 
            this.buttonCut.AutoSize = false;
            this.buttonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCut.Image = global::Notepad.Properties.Resources.cut;
            this.buttonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(25, 25);
            this.buttonCut.Text = "cutText";
            // 
            // buttonCopy
            // 
            this.buttonCopy.AutoSize = false;
            this.buttonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCopy.Image = global::Notepad.Properties.Resources.copy;
            this.buttonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(25, 25);
            this.buttonCopy.Text = "copyText";
            // 
            // buttonPaste
            // 
            this.buttonPaste.AutoSize = false;
            this.buttonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPaste.Image = global::Notepad.Properties.Resources.paste;
            this.buttonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(25, 25);
            this.buttonPaste.Text = "pasteText";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(25, 25);
            // 
            // buttonUndo
            // 
            this.buttonUndo.AutoSize = false;
            this.buttonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUndo.Image = global::Notepad.Properties.Resources.undo;
            this.buttonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(25, 25);
            this.buttonUndo.Text = "undo";
            // 
            // buttonRedo
            // 
            this.buttonRedo.AutoSize = false;
            this.buttonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRedo.Image = global::Notepad.Properties.Resources.redo;
            this.buttonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(25, 25);
            this.buttonRedo.Text = "redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(25, 25);
            // 
            // buttonFind
            // 
            this.buttonFind.AutoSize = false;
            this.buttonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonFind.Image = global::Notepad.Properties.Resources.find;
            this.buttonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(25, 25);
            this.buttonFind.Text = "find";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(25, 25);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.AutoSize = false;
            this.buttonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonZoomIn.Image = global::Notepad.Properties.Resources.zoom_in;
            this.buttonZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(25, 25);
            this.buttonZoomIn.Text = "zoomIn";
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.AutoSize = false;
            this.buttonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonZoomOut.Image = global::Notepad.Properties.Resources.zoom_out;
            this.buttonZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(25, 25);
            this.buttonZoomOut.Text = "zoomOut";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1184, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1184, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 484);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1192, 546);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kubi\'s Notepad";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDown;
        private System.Windows.Forms.ToolStripMenuItem menuNewFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuCloseFile;
        private System.Windows.Forms.ToolStripMenuItem menuExitProgram;
        private System.Windows.Forms.ToolStripDropDownButton editDropDown;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuRedo;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStripDropDownButton searchDropDown;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.ToolStripMenuItem menuReplace;
        private System.Windows.Forms.ToolStripDropDownButton menuFontSize;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFontFamily;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton buttonNewFile;
        private System.Windows.Forms.ToolStripButton buttonOpenFile;
        private System.Windows.Forms.ToolStripButton buttonSaveFile;
        private System.Windows.Forms.ToolStripButton buttonSaveAll;
        private System.Windows.Forms.ToolStripButton buttonCloseFile;
        private System.Windows.Forms.ToolStripButton buttonCloseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonCut;
        private System.Windows.Forms.ToolStripButton buttonCopy;
        private System.Windows.Forms.ToolStripButton buttonPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonUndo;
        private System.Windows.Forms.ToolStripButton buttonRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton buttonFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton buttonZoomOut;
        private System.Windows.Forms.ToolStripButton buttonZoomIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

