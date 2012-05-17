namespace KruskalWin32
{
    partial class NewGraphCreateDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbVertexNumber = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of verties for new graph";
            // 
            // tbVertexNumber
            // 
            this.tbVertexNumber.Location = new System.Drawing.Point(16, 30);
            this.tbVertexNumber.Name = "tbVertexNumber";
            this.tbVertexNumber.Size = new System.Drawing.Size(198, 20);
            this.tbVertexNumber.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(16, 56);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 26);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewGraphCreateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 94);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tbVertexNumber);
            this.Controls.Add(this.label1);
            this.Name = "NewGraphCreateDialog";
            this.Text = "Create graph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVertexNumber;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button1;
    }
}