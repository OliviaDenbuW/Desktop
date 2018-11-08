using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfDemo33
{
	public class RGBToHTMLColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var rgbCode = value as RGBCode;

			if (rgbCode != null)
			{
				return $"#{rgbCode.R:x2}{rgbCode.G:x2}{rgbCode.B:x2}";
			}

			return "";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
