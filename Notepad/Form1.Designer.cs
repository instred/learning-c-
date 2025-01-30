namespace Notepad
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRenameFile = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.AcceptsReturn = true;
            this.mainTextBox.AcceptsTab = true;
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainTextBox.Location = new System.Drawing.Point(12, 56);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTextBox.Size = new System.Drawing.Size(1168, 478);
            this.mainTextBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
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
            this.menuRenameFile,
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
            this.menuNewFile.Size = new System.Drawing.Size(180, 22);
            this.menuNewFile.Text = "New";
            // 
            // menuOpenFile
            // 
            this.menuOpenFile.Name = "menuOpenFile";
            this.menuOpenFile.Size = new System.Drawing.Size(180, 22);
            this.menuOpenFile.Text = "Open";
            // 
            // menuSaveFile
            // 
            this.menuSaveFile.Name = "menuSaveFile";
            this.menuSaveFile.Size = new System.Drawing.Size(180, 22);
            this.menuSaveFile.Text = "Save";
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(180, 22);
            this.menuSaveAs.Text = "Save As...";
            // 
            // menuRenameFile
            // 
            this.menuRenameFile.Name = "menuRenameFile";
            this.menuRenameFile.Size = new System.Drawing.Size(180, 22);
            this.menuRenameFile.Text = "Rename";
            // 
            // menuCloseFile
            // 
            this.menuCloseFile.Name = "menuCloseFile";
            this.menuCloseFile.Size = new System.Drawing.Size(180, 22);
            this.menuCloseFile.Text = "Close";
            // 
            // menuExitProgram
            // 
            this.menuExitProgram.Name = "menuExitProgram";
            this.menuExitProgram.Size = new System.Drawing.Size(180, 22);
            this.menuExitProgram.Text = "Exit";
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
            this.menuUndo.Size = new System.Drawing.Size(122, 22);
            this.menuUndo.Text = "Undo";
            // 
            // menuRedo
            // 
            this.menuRedo.Name = "menuRedo";
            this.menuRedo.Size = new System.Drawing.Size(122, 22);
            this.menuRedo.Text = "Redo";
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.Size = new System.Drawing.Size(122, 22);
            this.menuCut.Text = "Cut";
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.Size = new System.Drawing.Size(122, 22);
            this.menuCopy.Text = "Copy";
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.Size = new System.Drawing.Size(122, 22);
            this.menuPaste.Text = "Paste";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(122, 22);
            this.menuDelete.Text = "Delete";
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Name = "menuSelectAll";
            this.menuSelectAll.Size = new System.Drawing.Size(122, 22);
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
            this.menuFind.Size = new System.Drawing.Size(124, 22);
            this.menuFind.Text = "Find...";
            // 
            // menuReplace
            // 
            this.menuReplace.Name = "menuReplace";
            this.menuReplace.Size = new System.Drawing.Size(124, 22);
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
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // menuFontFamily
            // 
            this.menuFontFamily.Name = "menuFontFamily";
            this.menuFontFamily.Size = new System.Drawing.Size(136, 22);
            this.menuFontFamily.Text = "Font Family";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator1,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripSeparator2,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator3,
            this.toolStripButton12,
            this.toolStripSeparator4,
            this.toolStripButton14,
            this.toolStripButton13});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1192, 28);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolMenuIcons";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton1.Text = "newFile";
            this.toolStripButton1.Click += new System.EventHandler(this.newFile_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton2.Text = "openFile";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton3.Text = "saveFile";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton4.Text = "saveAll";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton5.Text = "closeFile";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton6.Text = "closeAll";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(25, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::Notepad.Properties.Resources.cut;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton7.Text = "cutText";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::Notepad.Properties.Resources.copy;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton8.Text = "copyText";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.AutoSize = false;
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::Notepad.Properties.Resources.paste;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton9.Text = "pasteText";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(25, 25);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = global::Notepad.Properties.Resources.undo;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton10.Text = "undo";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.AutoSize = false;
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = global::Notepad.Properties.Resources.redo;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton11.Text = "redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(25, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.AutoSize = false;
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = global::Notepad.Properties.Resources.find;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton12.Text = "find";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(25, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.AutoSize = false;
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = global::Notepad.Properties.Resources.zoom_in;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton14.Text = "zoomIn";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.AutoSize = false;
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = global::Notepad.Properties.Resources.zoom_out;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton13.Text = "zoomOut";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1192, 546);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kubi\'s Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDown;
        private System.Windows.Forms.ToolStripMenuItem menuNewFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuRenameFile;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
    }
}

