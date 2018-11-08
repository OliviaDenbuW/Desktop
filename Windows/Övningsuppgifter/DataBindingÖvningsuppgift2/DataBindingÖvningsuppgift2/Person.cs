using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingÖvningsuppgift2
{
    //1 Gör klass
    //2 Global varibale
    public class Person : INotifyPropertyChanged
    {
        //private fält
        private string _name;
        //när vi sätter den måste vi trigga eventet för att gränsnittet ska få reda på det 
        public string Name
        {
            get { return _name; }
            set {
                //Väårje gång name satts så görs eventer, Man behöver inte säga vilket even det gör CalledMember (vilken prop man är i)
                //OnPropertyCHangerd(name)
                //SAMMANFATTNING
                //ända änringen vi gjorde var i klassen
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Email { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        //nu har vi sättt att meddela gränssnittet
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
