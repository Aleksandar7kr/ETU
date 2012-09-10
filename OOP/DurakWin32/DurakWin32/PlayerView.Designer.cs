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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.namePlayer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.handVew = new System.Windows.Forms.FlowLayoutPanel();
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
            this.splitPeople.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitPeople.Location = new System.Drawing.Point(0, 0);
            this.splitPeople.Name = "splitPeople";
            this.splitPeople.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPeople.Panel1
            // 
            this.splitPeople.Panel1.Controls.Add(this.textBox1);
            this.splitPeople.Panel1.Controls.Add(this.namePlayer);
            this.splitPeople.Panel1.Controls.Add(this.pictureBox1);
            this.splitPeople.Panel1.Margin = new System.Windows.Forms.Padding(5);
            this.splitPeople.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.splitPeople.Panel1MinSize = 17;
            // 
            // splitPeople.Panel2
            // 
            this.splitPeople.Panel2.Controls.Add(this.handVew);
            this.splitPeople.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitPeople.Panel2MinSize = 17;
            this.splitPeople.Size = new System.Drawing.Size(310, 400);
            this.splitPeople.SplitterDistance = 100;
            this.splitPeople.SplitterWidth = 1;
            this.splitPeople.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(97, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 66);
            this.textBox1.TabIndex = 2;
            // 
            // namePlayer
            // 
            this.namePlayer.AutoSize = true;
            this.namePlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.namePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePlayer.ForeColor = System.Drawing.Color.Yellow;
            this.namePlayer.Location = new System.Drawing.Point(97, 5);
            this.namePlayer.Name = "namePlayer";
            this.namePlayer.Size = new System.Drawing.Size(65, 24);
            this.namePlayer.TabIndex = 1;
            this.namePlayer.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DurakWin32.People.people1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // handVew
            // 
            this.handVew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.handVew.Location = new System.Drawing.Point(0, 0);
            this.handVew.Name = "handVew";
            this.handVew.Size = new System.Drawing.Size(310, 299);
            this.handVew.TabIndex = 0;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitPeople);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(310, 400);
            this.splitPeople.Panel1.ResumeLayout(false);
            this.splitPeople.Panel1.PerformLayout();
            this.splitPeople.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPeople)).EndInit();
            this.splitPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label namePlayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel handVew;
    }
}
