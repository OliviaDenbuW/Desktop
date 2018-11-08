using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Inlämning2WPF
{
    public class AddCommand : ICommand
    {
        //För att koppla till ViewModel.cs
        private CommandViewModel _vm;

        private void VMOnPropertyChange(object sender, PropertyChangedEventArgs propertyChangedOnEvent)
        {
            if (propertyChangedOnEvent.PropertyName == "NewItem")
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        //Själva kommandot
        public void Execute(object parameter)
        {
            //Lägger in den där
            _vm.Items.Add(_vm.NewColor);
            _vm.NewColor = String.Empty;
        }
    }
}
