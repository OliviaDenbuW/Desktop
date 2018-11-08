using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Metod som ska söka efter data i databasen och visa datan i
        //i dataGridView1 i Windows forms-rutan (dock utan felhantering)
        public void DisplayData()
        {
            /***********************************************
             
             SqlConnection & SqlCommand används tillsammans
             för att hämta data ur databasen

             **********************************************/

            //Skapa connection string
            SqlConnection connection = new SqlConnection("Data source = localhost; Initial Catalog = AddressBookOlivia; Integrated Security = True");
            SqlCommand command = new SqlCommand();

            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Address";
            connection.Open();

            //Adaptern håller datan och sparar den i ett dataSet som innehåller dataTables
            SqlDataAdapter adapter = null;
            using(adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dataTable);
            }
            dataSet.Tables.Add(dataTable);

            dataGridView1.DataSource = dataSet.Tables[0];

            command.Dispose();
            command = null;
            connection.Close();      

        }

        //Metod för att uppdatera, lägga till, ta bort i databasen - Alltså CRUD-operationer
        private void ChangeData(int ID, string name)
        {
            SqlConnection connection = new SqlConnection("Data source = localhost");

            SqlCommand command = new SqlCommand();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update Person Set Person.Name = '" + "' Where PersonID = " + ID + ";";
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var name = textBox1.Text;
            //ChangeData(ID, name);
        }
    } 
}
