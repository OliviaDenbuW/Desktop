using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex9_2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      label4.Text = "";
    }

    private void button2_Click(object sender, EventArgs e) {
      errorProvider1.Clear();
      errorProvider2.Clear();
      errorProvider3.Clear();
      bool ok1 = textBox1.Text.Length > 0;
      if (!ok1)
        errorProvider1.SetError(textBox1, "Skriv ditt namn");
      int längd;
      bool ok2 = int.TryParse(textBox2.Text, out längd);
      if (!ok2)
        errorProvider2.SetError(textBox2, "Felaktig längd");
      double vikt;
      bool ok3 = double.TryParse(textBox3.Text, out vikt);
      if (!ok3)
        errorProvider3.SetError(textBox3, "Felaktig vikt");
      if (ok1 && ok2 && ok3)
        label4.Text = string.Format("Hej " + textBox1.Text + ". Du väger {0:f2} kg/cm.", vikt/längd);
      else
        label4.Text = "";
    }
  }
}