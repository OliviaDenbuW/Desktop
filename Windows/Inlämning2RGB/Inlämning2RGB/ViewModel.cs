using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Inlämning2RGB
{
    public class ViewModel : INotifyPropertyChanged
    {
        private RGBCode _code;

        private string _newColor;
        private string _selectedColor;

        public ViewModel()
        {
            _code = new RGBCode
            {
                R = 0,
                G = 0,
                B = 0
            };
            _code.PropertyChanged += (sender, args) => OnPropertyChanged("Code");

            Save = new SaveCommand(this);
        }

        public ICommand Save { get; }

        //Code är slutresultatet av allt
        public RGBCode Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("Code");
            }
        }

        public string SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                _selectedColor = value;
                OnPropertyChanged("SelectedColor");
            }
        }

        public string NewColor
        {
            get { return _newColor; }
            set
            {
                _newColor = value;
                OnPropertyChanged("NewColor");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
