using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TentamenWPF
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Person _newPerson;
        private Person _selectedPerson;

        public ViewModel()
        {
            Persons = new ObservableCollection<Person>();

            Save = new SaveCommand(this);
            Remove = new RemoveCommand(this);
            //Search = new SearchCommand(this);
        }

        public ObservableCollection<Person> Persons { get; set; }

        public ICommand Save { get; }
        public ICommand Remove { get; }
        //public ICommand Search { get; set; }

        public Person NewPerson
        {
            get { return _newPerson; }
            set
            {
                _newPerson = value;
                OnPropertyChanged("NewPerson");
            }
        }

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
