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

namespace Övningsuppgift3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.mediaElement.Source = new Uri("C:\\Users\\Olivia\\Desktop\\Windows\\sampleMedia.mp4");
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            this.mediaElement.Play();
        }

        private void btnPaus_Click(object sender, RoutedEventArgs e)
        {
            this.mediaElement.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            this.mediaElement.Stop();
        }
    }
}
