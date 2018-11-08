using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TentamenWPF
{
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
            if (propertyChangedEventArgs.PropertyName == "SelectedPerson")
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object parameter)
        {
            return _vm.SelectedPerson != null;
        }

        public void Execute(object parameter)
        {
            _vm.Persons.Remove(_vm.SelectedPerson);
        }

        public event EventHandler CanExecuteChanged;
    }
}
