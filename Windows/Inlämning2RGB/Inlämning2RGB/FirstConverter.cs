using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Inlämning2RGB
{
    public class FirstConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var finalColor = values as RGBCode[];
            ViewModel vm = new ViewModel();

            if (finalColor != null)
            {
                return $"#{finalColor[0].R:x2}{finalColor[1].G:x2}{finalColor[2].B:x2}"; ;
            }

            return "";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
