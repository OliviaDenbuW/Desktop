using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TentamenWPF
{
    public class SaveCommand : ICommand
    {
        private ViewModel _vm;

        public SaveCommand(ViewModel vm)
        {
            _vm = vm;
            _vm.PropertyChanged += VmOnPropertyChanged;
        }

        private void VmOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if ((propertyChangedEventArgs.PropertyName == "NewName") &&
                (propertyChangedEventArgs.PropertyName == "NewPhone") &&
                (propertyChangedEventArgs.PropertyName == "NewEmail"))
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object parameter)
        {
            return _vm.NewPerson != null;
        }

        public void Execute(object parameter)
        {
            _vm.Persons.Add(_vm.NewPerson);
            _vm.NewPerson = null;
        }

        public event EventHandler CanExecuteChanged;
    }
}
