using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo33
{
	public class ViewModel : INotifyPropertyChanged
	{
		private RGBCode _code;

		public ViewModel()
		{
			_code = new RGBCode {R=0, G=0, B=0};
			_code.PropertyChanged += (sender, args) => OnPropertyChanged("Code");
		}

		public RGBCode Code
		{
			get { return _code; }
			set
			{
				_code = value; 
				OnPropertyChanged("Code");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
