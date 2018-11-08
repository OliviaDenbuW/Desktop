using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoDataBindingÖvningsuppgift3
{
    public class RemoveCommand : ICommand
    {
        private ViewModel _vm;

        //föpr att sätta _vm
        public RemoveCommand(ViewModel vm)
        {
            _vm = vm;
            _vm.PropertyChanged += VMOnPropertyChanged;
        }

        private void VMOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedOnEvent)
        {
            if (propertyChangedOnEvent.PropertyName == "SelectedItem")
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object parameter)
        {
            //Om det finns något valt ska vara skild från null
            return _vm.SelectedItem != null;
        }

        //Själva commandor
        public void Execute(object parameter)
        {
            _vm.Items.Remove(_vm.SelectedItem);
        }


        //Måste hålla reda på om vi kan köra den elr inte
        public event EventHandler CanExecuteChanged;
    }
}
