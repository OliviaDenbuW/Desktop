using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Inlämning2RGB
{
    public class RGBToHTMLColorConverter : IValueConverter /*IMultiValueConverter*/
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var rgbCode = value as RGBCode;

            if (rgbCode != null)
            {
                //Kom på vad som ska bytas ut
                return $"#{rgbCode.R:x2}{rgbCode.G:x2}{rgbCode.B:x2}";
                //return $"#100";
            }

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        //public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        //{
        //    var finalColor = values as RGBCode[];
        //    ViewModel vm = new ViewModel();
        //    vm.Code = finalColor;

        //    if (finalColor != null)
        //    {
        //        return $"#{finalColor[0].R:x2}{finalColor[1].G:x2}{finalColor[2].B:x2}"; ;
        //    }

        //    return "";
        //}

        //public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
