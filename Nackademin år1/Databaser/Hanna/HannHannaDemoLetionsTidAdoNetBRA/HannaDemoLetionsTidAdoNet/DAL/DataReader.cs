using HannaDemoLetionsTidAdoNet.Models;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace HannaDemoLetionsTidAdoNet.DAL
{
    public class DataReader
    {
        private SqlConnection conn = null;
        private const string OrderId = "OrderId";
        private const string ShipName = "ShipName";
        private const string ShipCity = "ShipCity";
        public DataReader()
        {
            var connectionString = Properties.Settings.Default.NorthwindConnection;
            conn = new SqlConnection(connectionString);
        }

        public BindingList<OrderModel> GetOrders(string CommandText, CommandType cmdType, SqlParameter[] param)
        {
            var orders = new BindingList<OrderModel>();

            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(CommandText, conn);
                cmd.CommandType = cmdType;

                if(param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var isNumber = int.TryParse(reader[OrderId].ToString(), out int orderId);

                    orders.Add(new OrderModel
                    {
                        OrderId = orderId,
                        ShipName = reader[ShipName].ToString(),
                        ShipCity = reader[ShipCity].ToString()
                    });
                }

                conn.Close();
            }

            return orders;
        }
    }
}
