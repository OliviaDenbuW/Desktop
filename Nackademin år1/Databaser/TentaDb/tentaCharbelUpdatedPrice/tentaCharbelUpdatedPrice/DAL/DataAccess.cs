using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace tentaCharbelUpdatedPrice.DAL
{
    /*
     --Uppgift 6
    Metod i c# som döper till UpdatedPrice(). Ska uppdatera priset på alla 
    prod med 10%. ENBART prod i kateg BEVERAGES - ADO.NET
     */
    class DataAccess
    {
        private SqlConnection conn = null;

        public DataAccess()
        {
            //Skapa connection
            var cs = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;";
            conn = new SqlConnection(cs);
        }

        public bool UpdatedPrices()
        {
            SqlCommand cmd = null;
            int res = 0;

            cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update p set p.UnitPrice = p.UnitPrice*1.1 " +
                               "from Products p " +
                               "inner join Categories c on p.CategoryID = c.CategoryID " +
                               "where c.CategoryName = 'Beverages'; ";

            conn.Open();
            res = cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            conn.Close();

            if (res > 0)
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
