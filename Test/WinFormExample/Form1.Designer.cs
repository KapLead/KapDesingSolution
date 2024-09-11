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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kapLabel1 = new KapDesign.WinForm.KapLabel();
            this.kapLabel2 = new KapDesign.WinForm.KapLabel();
            this.SuspendLayout();
            // 
            // kapLabel1
            // 
            this.kapLabel1.BackColor = System.Drawing.Color.Transparent;
            this.kapLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kapLabel1.Image = ((System.Drawing.Image)(resources.GetObject("kapLabel1.Image")));
            this.kapLabel1.Location = new System.Drawing.Point(438, 137);
            this.kapLabel1.Name = "kapLabel1";
            this.kapLabel1.Size = new System.Drawing.Size(160, 60);
            this.kapLabel1.TabIndex = 0;
            this.kapLabel1.Text = "kapLabel1";
            this.kapLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kapLabel2
            // 
            this.kapLabel2.BackColor = System.Drawing.Color.Transparent;
            this.kapLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kapLabel2.Image = ((System.Drawing.Image)(resources.GetObject("kapLabel2.Image")));
            this.kapLabel2.Location = new System.Drawing.Point(249, 104);
            this.kapLabel2.Name = "kapLabel2";
            this.kapLabel2.Size = new System.Drawing.Size(160, 60);
            this.kapLabel2.TabIndex = 1;
            this.kapLabel2.Text = "kapLabel2";
            this.kapLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 541);
            this.Controls.Add(this.kapLabel2);
            this.Controls.Add(this.kapLabel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinForm Example";
            this.ResumeLayout(false);

        }

        #endregion

        private KapDesign.WinForm.KapLabel kapLabel1;
        private KapDesign.WinForm.KapLabel kapLabel2;
    }
}

