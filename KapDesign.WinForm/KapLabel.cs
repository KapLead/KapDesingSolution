using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KapDesign.WinForm.Annotations;
using KapDesign.WinForm.Core;
using KapDesign.WinForm.Effects;

namespace KapDesign.WinForm
{
    public class KapLabel : Label, INotifyPropertyChanged
    {
        private DropShadowEffect _effect = null;

        [Category("Kap"),Browsable(true),Localizable(true)]
        [EditorBrowsable(EditorBrowsableState.Always),RefreshProperties(RefreshProperties.All)]
        public DropShadowEffect Effect {
            get => _effect;
            set
            {
                if (Equals(value, _effect)) return;
                _effect = value;
                OnPropertyChanged();
            }
        }


        public KapLabel()
        {
            _effect = new DropShadowEffect();
            Padding op;
            PropertyChanged+= (sender, args) => Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Transparent), e.ClipRectangle);

            var ha = TextAlign.GetAlignment();
            var va = TextAlign.GetLineAlignment();

            if (Effect != null)
            {
                var rad = Math.PI / 180.0;
                var dx = Math.Sin(rad * Effect.Direction) * Effect.Radius;
                var dy = Math.Cos(rad * Effect.Direction) * Effect.Radius;
                var round = e.ClipRectangle;
                round.Offset((int)dx,(int)dy);
                e.Graphics.DrawString(Text,Font,new SolidBrush(Styles.Currents.Style.Foreground),round,new StringFormat
                { Alignment = ha, LineAlignment = va });
            }

            e.Graphics.DrawString(Text,Font,new SolidBrush(Styles.Currents.Style.Foreground),e.ClipRectangle,new StringFormat
            {
                Alignment = ha, LineAlignment = va 
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

    }
}
