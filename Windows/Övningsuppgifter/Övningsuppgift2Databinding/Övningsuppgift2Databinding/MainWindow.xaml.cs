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

namespace Övningsuppgift2Databinding
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

            _person = new Person("Olivia", "odw@gmail.com");
            DataContext = _person;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _person.Name = "Kalle";
        }
    }
}
