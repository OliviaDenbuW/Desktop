using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tentaCharbelEntityFramework1.DAL;

namespace tentaCharbelEntityFramework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Fel
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            dataGridView1.DataSource = dataAccess.GetCustomers();
        }
    }
}
