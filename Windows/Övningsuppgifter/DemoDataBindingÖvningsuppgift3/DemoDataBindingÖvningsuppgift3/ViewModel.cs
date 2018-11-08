using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoDataBindingÖvningsuppgift3
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _newItem;
        private string _selectedItem;

        public ViewModel()
        {
            //Bheöver inte ngra propertyCHanges
            Items = new ObservableCollection<string>();

            //kan testa att köra app manuellt
            //Items.Add("test");

            //Måste stoppa in this som är command
            Add = new AddCommand(this);
            Remove = new RemoveCommand(this);
        }

        public ObservableCollection<string> Items { get; set; }

        //Vill inte ha publiv så ta bort set, kommer aldirg ändras behöver inte ha onptopchage
        public ICommand Add { get; }
        public ICommand Remove { get; }

        //Prop som meddelar om ändrinh
        public string SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public string NewItem
        {
            get { return _newItem; }
            set { _newItem = value;
                OnPropertyChanged("NewItem");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
