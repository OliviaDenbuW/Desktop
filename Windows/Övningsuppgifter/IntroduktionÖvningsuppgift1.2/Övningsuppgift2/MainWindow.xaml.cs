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

namespace Övningsuppgift2
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

        //Reverse
        private void button_Click(object sender, RoutedEventArgs e)
        {
            var s = new String(textBox.Text.ToCharArray());
            textBlock.Text = String.Join("", s.ToCharArray().Reverse());
        }

        //Add
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Skapa item först
            var item = new ListBoxItem
            {
                Content = this.textBox1.Text
            };

            this.listBox.Items.Add(item);
        }
    }
}
