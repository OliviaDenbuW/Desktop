using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using omtentaUppg1.DAL;

namespace omtentaUppg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void FindTwo()
        {
            DataAccess da = new DataAccess();
            DataSet customers = da.Find();

            dataGridView1.DataSource = customers.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FindTwo();
        }
    }
}
