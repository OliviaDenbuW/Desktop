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

namespace DataBindingÖvningsuppgift3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global var
        private RBGCode _rbg;

        public MainWindow()
        {
            InitializeComponent();

            _rbg = new RBGCode { R = 0, G = 0, B = 0 };

            //Sen sätta Datacontext till det
            //Cill nu binda
            //Vill binda txbox4 till hela objektet och inte bara r (binder deriekt till det som är satt i datacontext och inte bara en properrty)
            
            //DataContext = _rbg;
            //måste också då byta binding i coden från R till Code.R
            DataContext = new ViewModel();
        }
    }
}
