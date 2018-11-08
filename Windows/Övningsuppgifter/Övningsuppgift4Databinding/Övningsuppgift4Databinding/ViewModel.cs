using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Övningsuppgift4Databinding
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _newItem;
        private string _selectedItem;

        public ViewModel()
        {
            Items = new ObservableCollection<string>();
            Add = new AddCommand(this);
            Remove = new RemoveCommand(this);
        }

        public ObservableCollection<string> Items { get; set; }

        public ICommand Add { get; }
        public ICommand Remove { get; set; }

        public string NewItem
        {
            get { return _newItem; }
            set
            {
                _newItem = value;
                OnPropertyChanged("NewItem");
            }
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
