using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingÖvningsuppgift3
{
    //innehåller allt och implementerar Inot för att meddela gränssnitt
    //Vil också här implementaera INotifyCHanged (ngt propblem med detta............)
    public class RBGCode : INotifyPropertyChanged
    {
        private int _r;
        private int _g;
        private int _b;

        public int R
        {
            get { return _r; }
            set
            {
                _r = value;
                //den _code? triggar om propCHanged
                OnPropertyChanged("R");
            }
        }

        public int G
        {
            get { return _r; }
            set
            {
                _r = value;
                //den _code? triggar om propCHanged
                OnPropertyChanged("G");
            }
        }

        public int G { get; set; }

        public int B { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
