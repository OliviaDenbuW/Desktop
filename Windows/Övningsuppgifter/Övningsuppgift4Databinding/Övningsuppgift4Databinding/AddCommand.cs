using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Övningsuppgift4Databinding
{
    public class AddCommand : ICommand
    {
        //Referens till vm
        private ViewModel _vm;

        public AddCommand(ViewModel vm)
        {
            _vm = vm;
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
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return !String.IsNullOrEmpty(_vm.NewItem);
        }

        public void Execute(object parameter)
        {
            _vm.Items.Add(_vm.NewItem);
            _vm.NewItem = String.Empty;
        }
    }
}
