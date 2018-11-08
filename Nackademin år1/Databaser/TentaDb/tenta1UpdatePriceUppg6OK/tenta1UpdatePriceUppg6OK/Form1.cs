using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tenta1UpdatePriceUppg6OK.DAL;

namespace tenta1UpdatePriceUppg6OK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SelectOrders()
        {
            string cmdText = "select * from Orders";

            DataAccess da = new DataAccess();
            DataSet orders = da.MyExcecuteSelectCommand(cmdText, CommandType.Text, null);

            dataGridView1.DataSource = orders.Tables[0];
        }

        public void SelectAllCustomers()
        {
            DataAccess da = new DataAccess();
            DataSet customers = da.MyDirectSelectCommand();

            dataGridView1.DataSource = customers.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SelectOrders();
            SelectAllCustomers();
        }
    }
}
