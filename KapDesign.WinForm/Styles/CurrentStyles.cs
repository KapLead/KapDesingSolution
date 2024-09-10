using KapDesign.WinForm.Annotations;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace KapDesign.WinForm.Styles
{
    public class Currents : Style
    {
        public static Style Default { get; } = new Style
        {
            Foreground = Color.Black,
            Accept = Color.DarkBlue,
            Comment = Color.DimGray,
            Background = Color.White,
            FieldBackground = Color.DarkGray,
            AcceptBackground = Color.PowderBlue,
        };
  
        public static Style Dark { get; } = new Style
        {
            Foreground = Color.White,
            Accept = Color.FromArgb(155,20,20),
            Comment = Color.FromArgb(220,220,220),
            Background = Color.FromArgb(34,34,34),
            FieldBackground = Color.FromArgb(64,64,64),
            AcceptBackground = Color.FromArgb(85,22,22),
        };
     
        
        public static Style Style { get; set; } = new Style().Set(Default);

    }



    public class Style : INotifyPropertyChanged
    {
        #region private

        private Color _foreground = Color.Black;
        private Color _accept = Color.DarkBlue;
        private Color _comment = Color.DimGray;
        private Color _acceptBackground = Color.PowderBlue;
        private Color _fieldBackground = Color.DarkGray;
        private Color _background = Color.White;

        #endregion

        #region colors style

        public Color Foreground
        {
            get => _foreground;
            set
            {
                if (value.Equals(_foreground)) return;
                _foreground = value;
                OnPropertyChanged();
            }
        }
        public Color Accept
        {
            get => _accept;
            set
            {
                if (value.Equals(_accept)) return;
                _accept = value;
                OnPropertyChanged();
            }
        }
        public Color Comment
        {
            get => _comment;
            set
            {
                if (value.Equals(_comment)) return;
                _comment = value;
                OnPropertyChanged();
            }
        }
        public Color Background
        {
            get => _background;
            set
            {
                if (value.Equals(_background)) return;
                _background = value;
                OnPropertyChanged();
            }
        }
        public Color FieldBackground
        {
            get => _fieldBackground;
            set
            {
                if (value.Equals(_fieldBackground)) return;
                _fieldBackground = value;
                OnPropertyChanged();
            }
        }
        public Color AcceptBackground
        {
            get => _acceptBackground;
            set
            {
                if (value.Equals(_acceptBackground)) return;
                _acceptBackground = value;
                OnPropertyChanged();
            }
        }

        #endregion


        public Style Set(Style style)
        {
            Foreground = style.Foreground;
            Accept = style.Accept;
            Comment = style.Comment;
            Background = style.Background;
            FieldBackground = style.FieldBackground;
            AcceptBackground = style.AcceptBackground;
            return this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
