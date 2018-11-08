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

namespace GenomgångCharbel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Byggt connection, men inte öppnat
            string cs = "data source.; database=Sample2; intergrated security=SSPI";
            SqlConnection conn = new SqlConnection(cs);

            //skapa command
            SqlCommand cmd = new SqlCommand("SELECT * FROM Contact;", conn);

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            dataGridView1.DataSource = rdr;


            conn.Close();

        }
    }
}
