namespace DurakWin32
{
    partial class CardView
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
            this.splitCard = new System.Windows.Forms.SplitContainer();
            this.numberView = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitCard)).BeginInit();
            this.splitCard.Panel1.SuspendLayout();
            this.splitCard.Panel2.SuspendLayout();
            this.splitCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitCard
            // 
            this.splitCard.AllowDrop = true;
            this.splitCard.BackColor = System.Drawing.Color.Transparent;
            this.splitCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCard.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitCard.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.splitCard.IsSplitterFixed = true;
            this.splitCard.Location = new System.Drawing.Point(0, 0);
            this.splitCard.Margin = new System.Windows.Forms.Padding(0);
            this.splitCard.Name = "splitCard";
            this.splitCard.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCard.Panel1
            // 
            this.splitCard.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitCard.Panel1.Controls.Add(this.numberView);
            this.splitCard.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitCard.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitCard.Panel1.Click += new System.EventHandler(this.CardView_Click);
            this.splitCard.Panel1MinSize = 17;
            // 
            // splitCard.Panel2
            // 
            this.splitCard.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitCard.Panel2.Controls.Add(this.pictureBox);
            this.splitCard.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitCard.Panel2.Click += new System.EventHandler(this.CardView_Click);
            this.splitCard.Panel2MinSize = 17;
            this.splitCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitCard.Size = new System.Drawing.Size(45, 72);
            this.splitCard.SplitterDistance = 25;
            this.splitCard.SplitterWidth = 1;
            this.splitCard.TabIndex = 1;
            this.splitCard.Click += new System.EventHandler(this.CardView_Click);
            // 
            // numberView
            // 
            this.numberView.AutoSize = true;
            this.numberView.Location = new System.Drawing.Point(0, 0);
            this.numberView.Margin = new System.Windows.Forms.Padding(3);
            this.numberView.Name = "numberView";
            this.numberView.Size = new System.Drawing.Size(19, 17);
            this.numberView.TabIndex = 0;
            this.numberView.Text = "N";
            this.numberView.Visible = false;
            this.numberView.Click += new System.EventHandler(this.CardView_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(45, 46);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            this.pictureBox.Click += new System.EventHandler(this.CardView_Click);
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DurakWin32.PngSuits.back;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitCard);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "CardView";
            this.Size = new System.Drawing.Size(45, 72);
            this.Click += new System.EventHandler(this.CardView_Click);
            this.splitCard.Panel1.ResumeLayout(false);
            this.splitCard.Panel1.PerformLayout();
            this.splitCard.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCard)).EndInit();
            this.splitCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numberView;
        private System.Windows.Forms.SplitContainer splitCard;
        private System.Windows.Forms.PictureBox pictureBox;

    }
}
