using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOtutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayData();

        }

        private void ChangeData(int ID, string name)
        {

            SqlConnection connection = new SqlConnection("Data Source = localhost; Initial Catalog = johanna; Integrated Security = True");
          
            SqlCommand command = new SqlCommand();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update Person Set Person.Namn = '" + name + "' Where PersonID = " + ID + ";";

            connection.Open();

            command.ExecuteNonQuery();
            
            connection.Close();

            DisplayData();
        }
    

        public void DisplayData()
        {
            SqlConnection connection = new SqlConnection("Data Source = localhost; Initial Catalog = johanna; Integrated Security = True");

            SqlCommand command = new SqlCommand();
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();


            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Person";
            connection.Open();



            SqlDataAdapter adapter = null;
            using (adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(datatable);
            }
            dataset.Tables.Add(datatable);


            dataGridView1.DataSource = dataset.Tables[0];

            command.Dispose();
            command = null;
            connection.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var name = textBox1.Text;
            ChangeData(ID, name);
        }
    }
}
