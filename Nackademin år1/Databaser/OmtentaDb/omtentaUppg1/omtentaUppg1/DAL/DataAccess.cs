using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace omtentaUppg1.DAL
{
    class DataAccess
    {
        private SqlConnection conn = null;

        public DataAccess()
        {
            var cs = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;";
            conn = new SqlConnection(cs);
        }

        public DataSet Find(SqlParameter[] inputCustomerID)
        {
            SqlCommand cmd = null;
            DataSet dataset = new DataSet();
            DataTable table = new DataTable();

            cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select companyName, phone from Customers";

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@CustomerID";
            param.Value = inputCustomerID;

            if (param != null)
            {
                cmd.Parameters.AddRange(inputCustomerID);
            }

            conn.Open();

            SqlDataAdapter da = null;
            using (da = new SqlDataAdapter(cmd))
            {
                da.Fill(table);
            }

            dataset.Tables.Add(table);

            cmd.Dispose();
            cmd = null;
            conn.Close();

            return dataset;
        }
    }
}
