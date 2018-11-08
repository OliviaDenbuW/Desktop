using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tentaCharbelADO1.DAL;

namespace tentaCharbelADO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdatedPrice()
        {

        }

        public void GetCustomers()
        {
            string commandText = "select * from Customers";

            DataAccess da = new DataAccess();
            DataSet customers = da.ExcecuteSelectCommand(commandText, CommandType.Text, null);

            dataGridView1.DataSource = customers.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }
    }
}
