using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StapelTest {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      stapel1.Procent = 75;
      stapel2.Procent = 25;
    }
  }
}