using KapDesign.WinForm.Effects;
using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace KapDesign.WinForm.Converters
{
    public class DropShadowEffectConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) =>
            sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) =>
            destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (!(value is string str)) return base.ConvertFrom(context, culture, value);
            str = str.Trim();
            if (str.Length == 0) return (object)null;
            var res = new DropShadowEffect();
            string[] arr = str.Split('|');
           
            var c = arr.First()?.Split(',');
            if (c.Length == 4 && 
                int.TryParse(c[0],out int a) && 
                int.TryParse(c[1],out int r) && 
                int.TryParse(c[2],out int g) && 
                int.TryParse(c[3],out int b))
                res.Color = Color.FromArgb(a, r, g, b);
            else 
                res.Color = Styles.Currents.Style.Foreground;
         
            if (int.TryParse(arr[1], out int direct)) res.Direction = direct;
            if (int.TryParse(arr[2], out int radius)) res.Radius = radius;
            return (object)res;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType)
        {
            if (destinationType == null) throw new ArgumentNullException(nameof(destinationType));
            if (value is DropShadowEffect ds)
                return $"{ds.Color.A},{ds.Color.R},{ds.Color.G},{ds.Color.B}|{ds.Direction}|{ds.Radius}";
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            //if (context == null) throw new ArgumentNullException(nameof(context));
            //if (propertyValues == null) throw new ArgumentNullException(nameof(propertyValues));
            return (DropShadowEffect)context.PropertyDescriptor?.GetValue(context.Instance);
        }

        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) => true;

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(DropShadowEffect), attributes);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context) => true;
    }
}
