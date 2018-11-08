using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataBindingÖvningsuppgift3
{
    //För att fixa textbox4 (så att hela objektet kopplar till datacontext)
    public class RGBToHtmlColorConverter : IValueConverter
    {
        //Det som kommer in är object men vi castar om den
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var rgbCode = value as RBGCode;

            //Vi ska göra en sträng som 
            if (rgbCode != null)
            {
                //Blir två siffror med x2
                //Html koden (#RRGGBB och det är hexadecimaler så hexass
                //VIll göra är att ta R och göra om till hexa... formatet, vill ha 2 siffror, om en nia vill ha 09
                return $"#{rgbCode.R:x2)}{rgbCode.G:x2}{rgbCode.B:x2}";
            }

            return "";
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
