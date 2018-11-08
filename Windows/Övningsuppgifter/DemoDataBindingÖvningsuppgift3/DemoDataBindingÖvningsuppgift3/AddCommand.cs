using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoDataBindingÖvningsuppgift3
{
    //Så mankan anvädna det som ett command i gränssnittet
    public class AddCommand : ICommand
    {
        //Vill ha referens till VM för ändringar????
        private ViewModel _vm;

        //SKapar fält och tilldelar i ctor
        public AddCommand(ViewModel vm)
        {
            _vm = vm;
            //för ändra i additem
            _vm.PropertyChanged += VMOnPropertyChanged;
        }

        private void VMOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedOnEvent)
        {
            if (propertyChangedOnEvent.PropertyName == "NewItem")
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        

        //Kan bara exceut om finns värde
        public bool CanExecute(object parameter)
        {
            return !String.IsNullOrEmpty(_vm.NewItem);
        }

        //Själva kommnadeot
        public void Execute(object parameter)
        {
            //Lägger in den där
            _vm.Items.Add(_vm.NewItem);
            _vm.NewItem = String.Empty;
        }

        //måste ändras för när addItem ändras
        public event EventHandler CanExecuteChanged;
    }
}
