using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


//Namespace som importeras är de två sista
namespace omtentaUppg6ADO.DAL
{
    class DataAccess
    {
        //Vi kommer att behöva en connection
        private SqlConnection conn = null;

        /*Konstruktor (samma namn som klassen är kännetecken)
         * Det som sker "i" konstruktorn kommer ALLTID ATT SKE när man startar programmet.
         * ÉX) Om man i ett annat exempel vill skapa ett personobjekt, kan man via konstuktorn göra
                så att VARJE personobjekt som skapas får ett namn (ALLA personer har ett namn, så det
                blir onödigt att skriva kod för att skapa ett namn, varje gång en person skapas...
                Bättre att automatisera det via konstruktorn (koden skrivs bara en gång)

         * I det här fallet (ADO.net) så vill vi ALLTID koppla projeketet till en databas, därav 
           skapas kopplingen i konstruktorn (connection-string ligger där etc)
        */

        public DataAccess()
        {
            //Här blir själva kopplingen mellan den innan "nullade" connection (conn) och connectionsträngen
            //I cs (connectonstängen) defineras vilken databas du använder
            var cs = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;";
            conn = new SqlConnection(cs);
        }

        /*Det finns två typer av metoder: 
            1. Metod som HÄMTAR data (metoden skapar inga ändringar i databasens data, ex select * from db where ...)
            2. Metod som ÄNDRAR data (ex delete from db, update from db)
        */

        //Här är en metod som gör en ÄNDRING i databasen (det andra sättet är när man HÄMTAR data från db)
        /*Den här metoden returnerar antingen sant/falst. (Typ säker) att det returneras sant om ändringen
          man gjorde har skett, ex en kontaktaddress har uppdaterats till en ny, eller att någon har deletats från db
          */          
        public bool UpdateProductPrice()
        {
            //Skapar ett command objekt som vi först till null och sen skapar vi kopplingen(connection)
            //mellan "conn" och commandobjektet (cmd).
            //cmd-objektet kommer vi att använda som huvudibjekt för att ex skriva queries
            SqlCommand cmd = null;
            cmd = conn.CreateCommand();
            
            /*används som "ändringsreferens" för att se om ändringar har skett i databasen
              Om result är större än noll så returnerar metoden true och om result stannar kvar på
              noll så returnerar metoden false och inga ändringar har skett.
              Man initialiserar resultvariabeln till 0 för att ha ett startvärde.
            */
            int result = 0;

            /*För att kunna säga till db vad vi vill göra, så måste vi skapa en quesry. I vanliga fall
              i MySQL så skickar vi quesries rakt in i db från sql-programmet. Men nu är själva poängen
              att vi ska kunna via Visual Studio kunna skicka in quesries (optimering) och vi måste då här
              skriva hur quesryn ska se ut.

               cmd-objektet har två inbyggda funktioner
               1. CommandType (I vårt fall, lite simplare, så hårdkodar vi text, men Stored Procedure finns som alternativ)
               2. CommandText (Man säger att det är text... vet ej exakt)
            */
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update p set UnitPrice = UnitPrice * 1.15 " +
                "from Products p " +
                "inner join Categories c on p.CategoryID = c.CategoryID " +
                "where c.CategoryName = 'Seafood';";

            //Ovan har vi bara definerat vad som ska ske och vilka objekt som ska finnas
            //Connection måste alltid öppnas för att ovanstående ska kunna ske. Vi öppnar kopplingen till db
            conn.Open();

            //Måste man göra. Cmd-objektet mpste kopplas till result (den som sedan ger oss true/false)
            //Kollar upp mer sen
            result = cmd.ExecuteNonQuery();

            //Vet ej varför men måste alltid  ske
            cmd.Dispose();
            cmd = null;

            //VIKTIGT!! Måste alltid stänga connection så att den inte är öppen
            conn.Close();


            //Förklarat ovan
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //När vi hittar olivias exempel kan vi klippa in den koden här..... Metod där man HÄMTAR data
        
    }
}

/*
select * from Products
select * from Categories

select c.CategoryName, p.UnitPrice from Products p
inner join Categories c on p.CategoryID = c.CategoryID
where c.CategoryName = 'Seafood'

--1. Hitta vilka nyckelord från respektive tabell som finns i frågan
--	ex unitPrics (hittas i products) och categoryName (categories)
--2 Hitta LÄNKEN mellan dessa tabeller, kan vara en jättelång koppling
--  vvilket skulle skapa jättemånga joins
*/