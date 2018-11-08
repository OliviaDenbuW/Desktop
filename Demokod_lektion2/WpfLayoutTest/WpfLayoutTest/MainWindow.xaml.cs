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

namespace WpfLayoutTest
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var resume = new Resume
			{
				Name = txtName.Text,
				FullTime = rdoFullTime.IsChecked == true,
				KnowsCSharp = chkCSharp.IsChecked == true,
				KnowsCPlusPlus = chkCplusPlus.IsChecked == true,
				KnowsJavaScript = chkJavaScript.IsChecked == true,
				Role = cboRole.Text,
				StartDate = calender.SelectedDate ?? DateTime.Now
			};

			using (var dbContext = new MyDbContext())
			{
				dbContext.Resumes.Add(resume);
				dbContext.SaveChanges();
			}
		}
	}
}
