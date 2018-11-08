using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BilHyra {
  public partial class Form1 : Form {
    static int totAntal = 0;

    public Form1() {
      InitializeComponent();
      totAntal++;
      Visible = true;
    }

    private void button1_Click(object sender, EventArgs e) {
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      label4.Text = "Totalt pris:";
      errorProvider1.Clear();
      errorProvider2.Clear();
      errorProvider3.Clear();
    }

    private void button2_Click(object sender, EventArgs e) {
      double kurs, dagsPris;
      int antalDagar;
      errorProvider1.Clear();
      errorProvider2.Clear();
      errorProvider3.Clear();
      bool ok1 = double.TryParse(textBox1.Text, out kurs);
      bool ok2 =    int.TryParse(textBox2.Text, out antalDagar);
      bool ok3 = double.TryParse(textBox3.Text, out dagsPris);
      if (!ok1)
        errorProvider1.SetError(textBox1, "Ange ett tal med decimalkomma");
      if (!ok2)
        errorProvider2.SetError(textBox2, "Ange ett heltal");
      if (!ok3)
        errorProvider3.SetError(textBox3, "Ange ett tal med decimalkomma");
      if (ok1 && ok2 && ok3) {
        double totPris = antalDagar * dagsPris;
        label4.Text = string.Format("Totalt pris: {0:f2} \u20AC ({1:f2}kr)",
                                    totPris, totPris*kurs);
      }
      else
        label4.Text = "Totalt pris:";
    }

    private void button3_Click(object sender, EventArgs e) {
      new Form1();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
      if (--totAntal == 0)
        Application.Exit();
    }
  }
}