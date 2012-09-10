namespace Savage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWithoutSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splutMain = new System.Windows.Forms.SplitContainer();
            this.pView = new System.Windows.Forms.DataGridView();
            this.xyView = new System.Windows.Forms.DataGridView();
            this.resView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splutMain)).BeginInit();
            this.splutMain.Panel1.SuspendLayout();
            this.splutMain.Panel2.SuspendLayout();
            this.splutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitWithoutSaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitWithoutSaveToolStripMenuItem
            // 
            this.exitWithoutSaveToolStripMenuItem.Name = "exitWithoutSaveToolStripMenuItem";
            this.exitWithoutSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitWithoutSaveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitWithoutSaveToolStripMenuItem.Text = "Exit without save";
            this.exitWithoutSaveToolStripMenuItem.Click += new System.EventHandler(this.exitWithoutSaveToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcToolStripMenuItem,
            this.addColumnToolStripMenuItem,
            this.addRowToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            this.operationsToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
            // 
            // calcToolStripMenuItem
            // 
            this.calcToolStripMenuItem.Name = "calcToolStripMenuItem";
            this.calcToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.calcToolStripMenuItem.Text = "Calc";
            this.calcToolStripMenuItem.Click += new System.EventHandler(this.calcToolStripMenuItem_Click);
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addColumnToolStripMenuItem.Text = "Add column";
            this.addColumnToolStripMenuItem.Click += new System.EventHandler(this.addColumnToolStripMenuItem_Click);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addRowToolStripMenuItem.Text = "Add row";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // splutMain
            // 
            this.splutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splutMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splutMain.IsSplitterFixed = true;
            this.splutMain.Location = new System.Drawing.Point(0, 24);
            this.splutMain.Name = "splutMain";
            // 
            // splutMain.Panel1
            // 
            this.splutMain.Panel1.Controls.Add(this.pView);
            this.splutMain.Panel1.Controls.Add(this.xyView);
            // 
            // splutMain.Panel2
            // 
            this.splutMain.Panel2.Controls.Add(this.resView);
            this.splutMain.Size = new System.Drawing.Size(624, 418);
            this.splutMain.SplitterDistance = 418;
            this.splutMain.SplitterWidth = 1;
            this.splutMain.TabIndex = 1;
            // 
            // pView
            // 
            this.pView.AllowUserToAddRows = false;
            this.pView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pView.Location = new System.Drawing.Point(0, 268);
            this.pView.MultiSelect = false;
            this.pView.Name = "pView";
            this.pView.RowHeadersWidth = 50;
            this.pView.Size = new System.Drawing.Size(418, 150);
            this.pView.TabIndex = 1;
            // 
            // xyView
            // 
            this.xyView.AllowUserToAddRows = false;
            this.xyView.AllowUserToDeleteRows = false;
            this.xyView.AllowUserToResizeRows = false;
            this.xyView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.xyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xyView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xyView.Location = new System.Drawing.Point(0, 0);
            this.xyView.Name = "xyView";
            this.xyView.RowHeadersWidth = 50;
            this.xyView.Size = new System.Drawing.Size(418, 418);
            this.xyView.TabIndex = 0;
            // 
            // resView
            // 
            this.resView.AllowUserToAddRows = false;
            this.resView.AllowUserToDeleteRows = false;
            this.resView.AllowUserToResizeRows = false;
            this.resView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resView.Location = new System.Drawing.Point(0, 0);
            this.resView.Name = "resView";
            this.resView.ReadOnly = true;
            this.resView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resView.RowHeadersVisible = false;
            this.resView.Size = new System.Drawing.Size(205, 418);
            this.resView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.splutMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Savage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splutMain.Panel1.ResumeLayout(false);
            this.splutMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splutMain)).EndInit();
            this.splutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWithoutSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splutMain;
        private System.Windows.Forms.DataGridView pView;
        private System.Windows.Forms.DataGridView xyView;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.DataGridView resView;
    }
}

