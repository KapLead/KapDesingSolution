using System;
using System.Drawing;
using System.ComponentModel;
using KapDesign.WinForm.Converters;
using KapDesign.WinForm.Annotations;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KapDesign.WinForm.Effects
{
    [Serializable]
    [TypeConverter(typeof(DropShadowEffectConverter))]
    public class DropShadowEffect : INotifyPropertyChanged
    {
        #region private

        private Color _color = Styles.Currents.Style.Foreground;
        private double _direction = 45;
        private double _radius = 5;

        #endregion

        [Category("Kap"), Localizable(true), TypeConverter(typeof(ColorConverter)), Browsable(true), EditorBrowsable(EditorBrowsableState.Always), RefreshProperties(RefreshProperties.All)]
        public Color Color {
            get => _color;
            set
            {
                if (value.Equals(_color)) return;
                _color = value;
                OnPropertyChanged();
            }
        }

        [Category("Kap"), Localizable(true), TypeConverter(typeof(DoubleConverter)), Browsable(true), EditorBrowsable(EditorBrowsableState.Always), RefreshProperties(RefreshProperties.All)]
        public double Direction {
            get => _direction;
            set
            {
                if (value == _direction) return;
                _direction = value;
                OnPropertyChanged();
            }
        }

        [Category("Kap"),Localizable(true), TypeConverter(typeof(DoubleConverter)), Browsable(true),EditorBrowsable(EditorBrowsableState.Always),RefreshProperties(RefreshProperties.All)]
        public double Radius {
            get => _radius;
            set
            {
                if (value == _radius) return;
                _radius = value;
                OnPropertyChanged();
            }
        }



        public DropShadowEffect()
        {
            
        }

        public override string ToString() => $"{Color.A},{Color.R},{Color.G},{Color.B}|{Direction}|{Radius}";

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
