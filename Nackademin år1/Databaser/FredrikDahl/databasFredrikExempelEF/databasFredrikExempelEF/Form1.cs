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

namespace databasFredrikExempelEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Skapar en connection till databasen
            Northwind conn = new Northwind();

            //Lista med urval
            // List<Student> students = conn.Students.Where(x => x.Namn.Contains("kalle").ToList();

            //Lista utan urval svaret på frågan hamnar i students collectionen
            List<Student> students = conn.Students.ToList();


            foreach (var student in students)
            {
                MessageBox.Show(student.Namn);
            }
        }
    }
}
