using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfDemo34
{
	public class AddCommand : ICommand
	{
		// Vi behöver en referens till ViewModel för att kunna manipu
		private ViewModel _vm;

		public AddCommand(ViewModel vm)
		{
			_vm = vm;
			// Vi behöver veta när ViewModel ändras
			_vm.PropertyChanged += VmOnPropertyChanged;
		}

		private void VmOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			// Om NewItem ändrats behöver vi meddela gränssnittet att CanExecute kan ha ändrats
			if (propertyChangedEventArgs.PropertyName == "NewItem")
			{
				CanExecuteChanged?.Invoke(this, EventArgs.Empty);
			}
		}

		public bool CanExecute(object parameter)
		{
			return !String.IsNullOrEmpty(_vm.NewItem);
		}

		public void Execute(object parameter)
		{
			_vm.Items.Add(_vm.NewItem);
			_vm.NewItem = String.Empty;
		}

		public event EventHandler CanExecuteChanged;
	}
}
