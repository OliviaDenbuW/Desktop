using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex9_3 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void textBox_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == (char)Keys.Enter) {
        int milNu, milDå; 
        double liter;
        bool ok1 = int.TryParse(textBox1.Text, out milNu);
        bool ok2 = int.TryParse(textBox2.Text, out milDå);
        bool ok3 = double.TryParse(textBox3.Text, out liter);
        if (ok1 && ok2 && ok3) {
          labelMil.Text = "" + (milNu-milDå);
          labelPerMil.Text = string.Format("{0:f2}", liter/(milNu-milDå));
        }
        else {
          labelMil.Text = "";
          labelPerMil.Text = "";
          MessageBox.Show("Felaktiga indata");
        }
      }
    }
  }
}
