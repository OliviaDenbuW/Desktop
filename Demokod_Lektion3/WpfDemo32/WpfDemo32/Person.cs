using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo32
{
	public class Person : INotifyPropertyChanged
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				OnPropertyChanged();
			}
		}

		public string Email { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
