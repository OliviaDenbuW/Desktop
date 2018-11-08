using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Inlämning2WPF
{
    public class CommandViewModel : INotifyPropertyChanged
    {
        private string _newColor;
        private string _selectedItem;

        public CommandViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        //Representerar färgerna som är i listan
        public ObservableCollection<string> Items { get; set; }

        //AUTOGENERERAD
        //Kopplar samman med metoden OnPropertyChanged för att hålla koll på när ngt ändras
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Vill inte ha public
        //Kommer aldrig ändras så behöver inte ha OnPropertyChange
        public ICommand Add { get; }

        //Prop som meddelar när vi lagt till
        public string NewColor
        {
            get { return _newColor; }
            set
            {
                _newColor = value;
                OnPropertyChanged("NewItem");
            }
        }
    }
}
