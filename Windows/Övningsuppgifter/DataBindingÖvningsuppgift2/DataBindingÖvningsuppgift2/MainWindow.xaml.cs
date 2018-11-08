using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingÖvningsuppgift2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Person _person;

        public MainWindow()
        {
            InitializeComponent();

            _person = new Person { Name = "Håkan", Email = "hf@gmail.com" };
            //Tildela datacontext
            //Här brukar man ha en vymodell som ryms med det jag vill ha i gränssnitett (fyller vymodellen med allt man vill ha)
            //Blir vymodell.Person.vadManVillHa
            //Kan göra småkomponenter
            DataContext = _person;
            //Nu vill visa det (finns här nu)
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //ÄNdrar underliggande datat och då ska inte gränssnittet som det ser ut nu ändras
            //Gränssnittet får inte reda på det
            //för att få attt fungerar måste vi implementera
            _person.Name = "Kalle";
        }
    }
}
