namespace WinFormExample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.kapLabel1 = new KapDesign.WinForm.KapLabel();
            this.SuspendLayout();
            // 
            // kapLabel1
            // 
            this.kapLabel1.AutoSize = true;
            this.kapLabel1.Location = new System.Drawing.Point(179, 37);
            this.kapLabel1.Name = "kapLabel1";
            this.kapLabel1.Size = new System.Drawing.Size(57, 13);
            this.kapLabel1.TabIndex = 0;
            this.kapLabel1.Text = "kapLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 541);
            this.Controls.Add(this.kapLabel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinForm Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KapDesign.WinForm.KapLabel kapLabel1;
    }
}

