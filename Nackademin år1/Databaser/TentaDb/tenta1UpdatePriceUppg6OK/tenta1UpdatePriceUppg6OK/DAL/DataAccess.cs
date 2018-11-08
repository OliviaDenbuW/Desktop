using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using tenta1UpdatePriceUppg6OK;

namespace tenta1UpdatePriceUppg6OK.DAL
{
    public class DataAccess
    {
    /*
    Uppgift 6
    Metod i c# som döper till UpdatedPrice(). Ska uppdatera priset på alla 
    prod med 10%. ENBART prod i kateg BEVERAGES - ADO.NET
    */
        private SqlConnection conn = null;

        public DataAccess()
        {
            var cs = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;";
            conn = new SqlConnection(cs);
        }

        //ExcecuteSelectCommand
        public DataSet MyExcecuteSelectCommand(string cmdText, CommandType cmdType, SqlParameter[] param)
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

        //ExcecuteSelectCommand
        public DataSet MyDirectSelectCommand()
        {
            SqlCommand cmd = null;
            DataSet dataset = new DataSet();
            DataTable table = new DataTable();

            cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customers";
            
            /*if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }*/

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

        //MyExcecuteNonQuery
        public bool UpdatedPrice()
        {
            SqlCommand cmd = null;
            cmd = conn.CreateCommand();

            int result = 0;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update p set p.UnitPrice = p.UnitPrice * 2.1 " +
                "from Products p " +
                "inner join Categories c on p.CategoryID = c.CategoryID " +
                "where c.CategoryName = 'Beverages';";

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

        //MyExcecuteNonQuery
        public bool Update
    }
}
