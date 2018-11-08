using HannaDemoLetionsTidAdoNet.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HannaDemoLetionsTidAdoNet.UI
{
    public partial class Northwind2 : Form
    {
        public Northwind2()
        {
            InitializeComponent();

            LoadInitialData();
        }

        private void LoadInitialData()
        {
            DataReader reader = new DataReader();

            var commandText = "select OrderId, ShipName, ShipCity from Orders";

            var orders = reader.GetOrders(commandText, CommandType.Text, null);

            Northwind2Datagridview.DataSource = orders;
        }
    }
}
