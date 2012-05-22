namespace DurakWin32
{
    partial class TableView
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
            this.attackCardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.defenceCardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // attackCardPanel
            // 
            this.attackCardPanel.Location = new System.Drawing.Point(0, 0);
            this.attackCardPanel.Name = "attackCardPanel";
            this.attackCardPanel.Size = new System.Drawing.Size(316, 80);
            this.attackCardPanel.TabIndex = 0;
            // 
            // defenceCardPanel
            // 
            this.defenceCardPanel.Location = new System.Drawing.Point(0, 85);
            this.defenceCardPanel.Name = "defenceCardPanel";
            this.defenceCardPanel.Size = new System.Drawing.Size(316, 80);
            this.defenceCardPanel.TabIndex = 1;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.defenceCardPanel);
            this.Controls.Add(this.attackCardPanel);
            this.Name = "TableView";
            this.Size = new System.Drawing.Size(319, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel attackCardPanel;
        private System.Windows.Forms.FlowLayoutPanel defenceCardPanel;
    }
}
