namespace KruskalWin32
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeMinSpannedTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitMainForm = new System.Windows.Forms.SplitContainer();
            this.splitLeftPanel = new System.Windows.Forms.SplitContainer();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.splitRightPanel = new System.Windows.Forms.SplitContainer();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.openMatrixFile = new System.Windows.Forms.OpenFileDialog();
            this.saveGraphDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMainForm)).BeginInit();
            this.splitMainForm.Panel1.SuspendLayout();
            this.splitMainForm.Panel2.SuspendLayout();
            this.splitMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftPanel)).BeginInit();
            this.splitLeftPanel.Panel1.SuspendLayout();
            this.splitLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitRightPanel)).BeginInit();
            this.splitRightPanel.Panel1.SuspendLayout();
            this.splitRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openFile,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(146, 22);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeMinSpannedTreeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // makeMinSpannedTreeToolStripMenuItem
            // 
            this.makeMinSpannedTreeToolStripMenuItem.Enabled = false;
            this.makeMinSpannedTreeToolStripMenuItem.Name = "makeMinSpannedTreeToolStripMenuItem";
            this.makeMinSpannedTreeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.makeMinSpannedTreeToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.makeMinSpannedTreeToolStripMenuItem.Text = "Make min spanned tree";
            this.makeMinSpannedTreeToolStripMenuItem.Click += new System.EventHandler(this.makeMinSpannedTreeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.sourceCodeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // splitMainForm
            // 
            this.splitMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMainForm.Location = new System.Drawing.Point(0, 24);
            this.splitMainForm.Name = "splitMainForm";
            // 
            // splitMainForm.Panel1
            // 
            this.splitMainForm.Panel1.Controls.Add(this.splitLeftPanel);
            this.splitMainForm.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitMainForm.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitMainForm.Panel2
            // 
            this.splitMainForm.Panel2.Controls.Add(this.splitRightPanel);
            this.splitMainForm.Size = new System.Drawing.Size(1008, 516);
            this.splitMainForm.SplitterDistance = 480;
            this.splitMainForm.TabIndex = 2;
            // 
            // splitLeftPanel
            // 
            this.splitLeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeftPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.splitLeftPanel.Name = "splitLeftPanel";
            this.splitLeftPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeftPanel.Panel1
            // 
            this.splitLeftPanel.Panel1.Controls.Add(this.pbLeft);
            this.splitLeftPanel.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitLeftPanel.Panel2
            // 
            this.splitLeftPanel.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitLeftPanel.Size = new System.Drawing.Size(480, 516);
            this.splitLeftPanel.SplitterDistance = 466;
            this.splitLeftPanel.TabIndex = 0;
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLeft.Location = new System.Drawing.Point(0, 0);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(478, 464);
            this.pbLeft.TabIndex = 0;
            this.pbLeft.TabStop = false;
            // 
            // splitRightPanel
            // 
            this.splitRightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRightPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitRightPanel.Location = new System.Drawing.Point(0, 0);
            this.splitRightPanel.Name = "splitRightPanel";
            this.splitRightPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRightPanel.Panel1
            // 
            this.splitRightPanel.Panel1.Controls.Add(this.pbRight);
            this.splitRightPanel.Size = new System.Drawing.Size(524, 516);
            this.splitRightPanel.SplitterDistance = 466;
            this.splitRightPanel.TabIndex = 0;
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRight.Location = new System.Drawing.Point(0, 0);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(522, 464);
            this.pbRight.TabIndex = 0;
            this.pbRight.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.splitMainForm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "KruskalWin32";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.splitMainForm.Panel1.ResumeLayout(false);
            this.splitMainForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMainForm)).EndInit();
            this.splitMainForm.ResumeLayout(false);
            this.splitLeftPanel.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftPanel)).EndInit();
            this.splitLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            this.splitRightPanel.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRightPanel)).EndInit();
            this.splitRightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.SplitContainer splitMainForm;
        private System.Windows.Forms.SplitContainer splitLeftPanel;
        private System.Windows.Forms.SplitContainer splitRightPanel;
        private System.Windows.Forms.OpenFileDialog openMatrixFile;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeMinSpannedTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveGraphDialog;

    }
}

