using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingÖvningsuppgift3
{
    public class ViewModel : INotifyPropertyChanged
    {
        private RBGCode _code;

        public ViewModel()
        {
            _code = new RBGCode { R = 0, B = 0, G = 0 };
            _code.PropertyChanged += (sender, args) = OnPropertyChanged("Code");
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public RBGCode Code
        {
            get { return _code; }
            set
            {
                _code = value;
                //den _code? triggar om propCHanged
                OnPropertyChanged("Code");
            }
        }

        //Metod som kan trigga eventet med
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
