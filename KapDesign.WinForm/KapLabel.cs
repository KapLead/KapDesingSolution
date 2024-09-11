using System.Runtime.CompilerServices;
using KapDesign.WinForm.Annotations;
using KapDesign.WinForm.Core;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using KapDesign.WinForm.Properties;

namespace KapDesign.WinForm
{
    public class KapLabel : Label, INotifyPropertyChanged
    {


        public KapLabel() : base()
        {

            base.BackColor = Color.Transparent;
            base.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoSize = false;
            base.Width = 160; 
            base.Height = 60;
            PropertyChanged += (sender, args) => Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), base.ClientRectangle);

            var ha = TextAlign.GetAlignment();
            var va = TextAlign.GetLineAlignment();

            e.Graphics.DrawString(Text, Font, new SolidBrush(Styles.Currents.Style.Foreground), e.ClipRectangle, new StringFormat
            {
                Alignment = ha,
                LineAlignment = va
            });

        }

        #region event

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // KapLabel
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Image = global::KapDesign.WinForm.Properties.Resources.tr_1kx1k;
            this.ResumeLayout(false);

        }
    }
}
