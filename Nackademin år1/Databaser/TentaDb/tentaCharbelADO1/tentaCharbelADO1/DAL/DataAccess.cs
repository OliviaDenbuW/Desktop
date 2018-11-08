using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace tentaCharbelADO1.DAL
{
   internal class DataAccess
    {
        private SqlConnection conn = null;

        public DataAccess()
        {
            //Skapa connection
            var cs = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;";
            conn = new SqlConnection(cs);
        }

        public DataSet ExcecuteSelectCommand(string cmdText, CommandType cmdType, SqlParameter[] param)
        {
            SqlCommand cmd = null;
            DataSet dataset = new DataSet();
            DataTable table = new DataTable();

            cmd = conn.CreateCommand();

            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
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


        public bool MyExcecuteNonQuery(string cmdText, CommandType cmdType, SqlParameter[] param)
        {
            SqlCommand cmd = null;
            int result = 0;

            cmd = conn.CreateCommand();

            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            conn.Open();

            result = cmd.ExecuteNonQuery();

            cmd.Dispose();
            cmd = null;
            conn.Close();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }          
            
        }
    }
}
