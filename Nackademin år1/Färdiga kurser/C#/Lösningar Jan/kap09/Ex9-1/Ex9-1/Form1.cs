using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex9_1 {
  public partial class Form1 : Form {
    private int bildNr = 0;

    public Form1() {
      InitializeComponent();
      label1.Image = Image.FromFile(@"C:\Temp\bild0.gif");
    }

    private void button1_Click(object sender, EventArgs e) {
      bildNr = (bildNr + 1) % 2;
      label1.Image = Image.FromFile(@"C:\Temp\bild" + bildNr +".gif");
    }
  }
}