using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


public partial class StoredProcedures
{
    static void Main(string[] args)
    {
        InsertCurrency_CS();
    }

    [SqlProcedure()]
    public static void InsertCurrency_CS()
        
    {
        using (SqlConnection conn = new SqlConnection("database=Addressbook")
        {
            SqlCommand InsertCurrencyCommand = new SqlCommand();
            SqlParameter currencyCodeParam = new SqlParameter("@Addr", SqlDbType.NVarChar);
            SqlParameter nameParam = new SqlParameter("@Numb", SqlDbType.Int);
            SqlParameter areaParam = new SqlParameter("@Area", SqlDbType.NVarChar);

            currencyCodeParam.Value = "Somewhere";
            nameParam.Value = 17263;
            areaParam.Value = "Else";

            InsertCurrencyCommand.Parameters.Add(currencyCodeParam);
            InsertCurrencyCommand.Parameters.Add(nameParam);
            InsertCurrencyCommand.Parameters.Add(areaParam);

            InsertCurrencyCommand.CommandText =
                "INSERT INTO Address(StreetAddress, PostalNumber, PostalArea)" +
                "OUTPUT INSERTED.AddressID" +
                "VALUES(@Addr, @Numb, @Area)";

            InsertCurrencyCommand.Connection = conn;

            conn.Open();
            InsertCurrencyCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}