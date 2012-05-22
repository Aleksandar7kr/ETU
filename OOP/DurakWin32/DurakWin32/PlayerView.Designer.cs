namespace DurakWin32
{
    partial class PlayerView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitPeople = new System.Windows.Forms.SplitContainer();
            this.playerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitPeople)).BeginInit();
            this.splitPeople.Panel1.SuspendLayout();
            this.splitPeople.Panel2.SuspendLayout();
            this.splitPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitPeople
            // 
            this.splitPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPeople.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitPeople.IsSplitterFixed = true;
            this.splitPeople.Location = new System.Drawing.Point(0, 0);
            this.splitPeople.Name = "splitPeople";
            this.splitPeople.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPeople.Panel1
            // 
            this.splitPeople.Panel1.Controls.Add(this.pictureBox1);
            this.splitPeople.Panel1MinSize = 17;
            // 
            // splitPeople.Panel2
            // 
            this.splitPeople.Panel2.Controls.Add(this.playerName);
            this.splitPeople.Panel2MinSize = 17;
            this.splitPeople.Size = new System.Drawing.Size(92, 116);
            this.splitPeople.SplitterDistance = 98;
            this.splitPeople.SplitterWidth = 1;
            this.splitPeople.TabIndex = 0;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerName.ForeColor = System.Drawing.Color.Yellow;
            this.playerName.Location = new System.Drawing.Point(0, 0);
            this.playerName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(39, 13);
            this.playerName.TabIndex = 1;
            this.playerName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DurakWin32.People.people1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitPeople);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(92, 116);
            this.splitPeople.Panel1.ResumeLayout(false);
            this.splitPeople.Panel2.ResumeLayout(false);
            this.splitPeople.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPeople)).EndInit();
            this.splitPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label playerName;
    }
}
