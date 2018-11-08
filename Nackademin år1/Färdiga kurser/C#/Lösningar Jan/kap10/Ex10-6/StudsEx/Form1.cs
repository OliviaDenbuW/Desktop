using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudsEx {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      studsBoll1.Radie = 30;
      studsBoll1.Hastighet = 10;
      studsBoll1.HöjdMinskning = 10;
      studsBoll1.Starta();
    }
  }
}