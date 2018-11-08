using HannaDemoLetionsTidAdoNet.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HannaDemoLetionsTidAdoNet
{
    public partial class Northwind : Form
    {
        public Northwind()
        {
            InitializeComponent();

            LoadNorthWindOrders();
        }

        private void LoadNorthWindOrders()
        {
            var dataAccess = new DataAccess();
            var commandText = "select OrderId, ShipName, ShipCity from Orders";

            DataSet orders = dataAccess.ExecuteSelectCommand(commandText, CommandType.Text, null);

            NortwindDataGridView.DataSource = orders.Tables[0];
        }

        private void NortwindDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var newValue = NortwindDataGridView[e.ColumnIndex, e.RowIndex].Value;
            var columnName = NortwindDataGridView.Columns[e.ColumnIndex].HeaderText;
            var orderID = NortwindDataGridView[0, e.RowIndex].Value;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", orderID),
                new SqlParameter("@" + columnName, newValue)
            };

            var command = "update Orders set "
                            + columnName
                            + " = @" + columnName + " where  OrderId = @OrderId;";

            DataAccess dataAccess = new DataAccess();
            var result = dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);

            if (result == true)
            {
                ResultLable.Text = "All is well!";
            }
            else
            {
                ResultLable.Text = "Ohhh nooos!";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NortwindDataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < NortwindDataGridView.Rows.Count; i++)
                {
                    if (NortwindDataGridView.Rows[i].Selected)
                    {
                        var orderId = NortwindDataGridView[0, i].Value;

                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@OrderId", orderId)
                        };
                        
                        var command = "delete from [Order Details] where OrderId = @OrderId; delete from Orders where OrderId = @OrderId";

                        DataAccess dataAccess = new DataAccess();
                        var result = dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);

                        if (result == true)
                        {
                            NortwindDataGridView.Rows.RemoveAt(i);
                        }
                    }
                }
            }
        }
    }
}
