﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfDemo34
{
	// Se kommentarer i AddCommand.cs
	public class RemoveCommand : ICommand
	{
		private ViewModel _vm;

		public RemoveCommand(ViewModel vm)
		{
			_vm = vm;
			_vm.PropertyChanged += VmOnPropertyChanged;
		}

		private void VmOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			if (propertyChangedEventArgs.PropertyName == "SelectedItem")
			{
				CanExecuteChanged?.Invoke(this, EventArgs.Empty);
			}
		}

		public bool CanExecute(object parameter)
		{
			return _vm.SelectedItem != null;
		}

		public void Execute(object parameter)
		{
			_vm.Items.Remove(_vm.SelectedItem);
		}

		public event EventHandler CanExecuteChanged;
	}
}
