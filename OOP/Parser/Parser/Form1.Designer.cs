namespace Parser
{
    partial class Form1
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
            this.calcButton = new System.Windows.Forms.Button();
            this.fLabel = new System.Windows.Forms.Label();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcButton.Location = new System.Drawing.Point(7, 81);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(255, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calc";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fLabel
            // 
            this.fLabel.AutoSize = true;
            this.fLabel.Location = new System.Drawing.Point(4, 7);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(45, 13);
            this.fLabel.TabIndex = 1;
            this.fLabel.Text = "function";
            // 
            // fTextBox
            // 
            this.fTextBox.Location = new System.Drawing.Point(62, 4);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(200, 20);
            this.fTextBox.TabIndex = 2;
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(62, 30);
            this.startTextBox.Multiline = true;
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(200, 20);
            this.startTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "start coord";
            // 
            // resTextBox
            // 
            this.resTextBox.Location = new System.Drawing.Point(7, 110);
            this.resTextBox.Multiline = true;
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.ReadOnly = true;
            this.resTextBox.Size = new System.Drawing.Size(255, 97);
            this.resTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "epsilon";
            // 
            // epsTextBox
            // 
            this.epsTextBox.Location = new System.Drawing.Point(62, 55);
            this.epsTextBox.Multiline = true;
            this.epsTextBox.Name = "epsTextBox";
            this.epsTextBox.Size = new System.Drawing.Size(200, 20);
            this.epsTextBox.TabIndex = 7;
            this.epsTextBox.Text = "0,00001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.epsTextBox);
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.fTextBox);
            this.Controls.Add(this.fLabel);
            this.Controls.Add(this.calcButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox epsTextBox;
    }
}

