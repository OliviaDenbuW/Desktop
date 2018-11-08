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

namespace DbContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Rsumeobjekt
            var resume = new Resume
            {
                Id = 1,
                Name = txtName.Text,
                FullTime = rdoFullTime.IsChecked == true,
                KnowsCSharp = chkCSharo.IsChecked == true,
                KnowsCplusPlus = chkCPlusPlus.IsChecked == true,
                KnowsJavaScript = chkJavaScript.IsChecked == true,
                Role = cboRole.Text,
                StartDate = calender.SelectedDate ?? DateTime.Now //Om valt startdatum så tar man det, annars dagens (om det innan ?? är null tar den det efter)

            };

            using(var dbContext = new MyDbContext())
            {
                //Resumes är typ tabllen
                dbContext.Resumes.Add(resume);
                dbContext.SaveChanges();
            }

            //Add connection i ServerExplorer DataConnections
            (localdb)mssql
        }
    }
}
