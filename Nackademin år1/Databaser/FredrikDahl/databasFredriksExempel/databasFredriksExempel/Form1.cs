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

namespace databasFredriksExempel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Skapa connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;";

            conn.Open();

            //Skapa en fråga som ska köras
            SqlCommand cmd = new SqlCommand("select * from Customers", conn);

            //Kör frågan och ta emot svaret
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Ta fram värdet
                string namn = reader["City"].ToString();

                MessageBox.Show(namn);
            }
        }
    }
}
