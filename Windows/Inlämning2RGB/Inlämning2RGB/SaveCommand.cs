using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Inlämning2RGB
{
    public class SaveCommand : ICommand
    {
        private ViewModel _vm;

        public SaveCommand(ViewModel vm)
        {
            _vm = vm;
            // Vi behöver veta när ViewModel ändras
            _vm.PropertyChanged += VmOnPropertyChanged;
        }

        private void VmOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            // Om NewItem ändrats behöver vi meddela gränssnittet att CanExecute kan ha ändrats
            if (propertyChangedEventArgs.PropertyName == "Code")
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
            //if (propertyChangedEventArgs.PropertyName == "NewItem")
            //{
            //    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            //}
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
                //return !String.IsNullOrEmpty(_vm.Code);
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
