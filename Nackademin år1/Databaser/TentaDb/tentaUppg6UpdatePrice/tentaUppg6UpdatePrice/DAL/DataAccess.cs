using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace tentaUppg6UpdatePrice.DAL
{
    class DataAccess
    {
        /*
  --Uppgift 6
 Metod i c# som döper till UpdatedPrice(). Ska uppdatera priset på alla 
 prod med 10%. ENBART prod i kateg BEVERAGES - ADO.NET
  */
        private SqlConnection conn = null;

        public DataAccess()
        {
            var cs = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;";
            conn = new SqlConnection(cs);
        }

        public bool UpdatedPrice()
        {
            SqlCommand cmd = null;
            cmd = conn.CreateCommand();

            int result = 0;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update p set p.UnitPrice = p.UnitPrice * 1.1 " +
                "from Products p " +
                "inner join Categories c on p.CategoryID = c.CategoryID " +
                "where c.CategoryID = 'Beverages';";

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
