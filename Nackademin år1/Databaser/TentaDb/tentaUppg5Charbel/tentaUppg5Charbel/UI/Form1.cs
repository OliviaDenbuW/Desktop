using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tentaUppg5Charbel.DAL;

namespace tentaUppg5Charbel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataGridView1.DataSource = dataAccess.SuppliersWithMoreThanThree();
        }
    }
}
