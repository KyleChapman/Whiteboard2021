
namespace Whiteboard2021
{
    partial class formWhiteboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureCanvas = new System.Windows.Forms.PictureBox();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCanvas)).BeginInit();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureCanvas
            // 
            this.pictureCanvas.BackColor = System.Drawing.Color.White;
            this.pictureCanvas.Location = new System.Drawing.Point(0, 31);
            this.pictureCanvas.Name = "pictureCanvas";
            this.pictureCanvas.Size = new System.Drawing.Size(782, 522);
            this.pictureCanvas.TabIndex = 0;
            this.pictureCanvas.TabStop = false;
            this.pictureCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Repaint);
            this.pictureCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseButtonDown);
            this.pictureCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoved);
            this.pictureCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseButtonUp);
            // 
            // menuTop
            // 
            this.menuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(782, 28);
            this.menuTop.TabIndex = 1;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Options related to file management";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(165, 26);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Discard the current image and start a new one";
            this.menuFileNew.Click += new System.EventHandler(this.FileNew);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(165, 26);
            this.menuFileSave.Text = "&File";
            this.menuFileSave.ToolTipText = "Save the image (to its current location if available)";
            this.menuFileSave.Click += new System.EventHandler(this.FileSave);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(165, 26);
            this.menuFileSaveAs.Text = "Save &As...";
            this.menuFileSaveAs.ToolTipText = "Save the image to a specified location";
            this.menuFileSaveAs.Click += new System.EventHandler(this.FileSaveAs);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(165, 26);
            this.menuFileExit.Text = "&Exit";
            this.menuFileExit.ToolTipText = "Exit the application";
            this.menuFileExit.Click += new System.EventHandler(this.FileExit);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCopy,
            this.menuEditPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(49, 24);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.ToolTipText = "Options related to editing";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(177, 26);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Copy the image to the clipboard";
            this.menuEditCopy.Click += new System.EventHandler(this.EditCopy);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(177, 26);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Paste some supported content into the whiteboard";
            this.menuEditPaste.Click += new System.EventHandler(this.EditPaste);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(55, 24);
            this.menuHelp.Text = "&Help";
            this.menuHelp.ToolTipText = "Options related to help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuHelpAbout.Size = new System.Drawing.Size(157, 26);
            this.menuHelpAbout.Text = "&About";
            this.menuHelpAbout.ToolTipText = "Shows a message about this application";
            this.menuHelpAbout.Click += new System.EventHandler(this.HelpAbout);
            // 
            // formWhiteboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pictureCanvas);
            this.Controls.Add(this.menuTop);
            this.MainMenuStrip = this.menuTop;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "formWhiteboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kyle\'s Whiteboard";
            this.Load += new System.EventHandler(this.FileNew);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCanvas)).EndInit();
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCanvas;
        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
    }
}

