using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TentamenWPF
{
    public class SearchCommand
    {
        //// Vi behöver en referens till ViewModel för att kunna manipu
        //private ViewModel _vm;

        //public SearchCommand(ViewModel vm)
        //{
        //    _vm = vm;
        //    _vm.PropertyChanged += VmOnPropertyChanged;
        //}

        //private void VmOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        //{
        //    if (propertyChangedEventArgs.PropertyName == "NewPerson")
        //    {
        //        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        //    }
        //}

        //public bool CanExecute(object parameter)
        //{
        //    return _vm.NewPerson != null;
        //}

        //public void Execute(object parameter)
        //{
        //    _vm.Persons.Add(_vm.NewPerson);
        //    _vm.NewPerson = null;
        //}

        //public event EventHandler CanExecuteChanged;
    }
}
