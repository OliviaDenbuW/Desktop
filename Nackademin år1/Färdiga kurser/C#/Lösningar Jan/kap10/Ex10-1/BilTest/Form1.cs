using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BilTest {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      bil1.RegNr ="ABC123";
      bil1.Bilmärke = "Volvo";
      bil2.RegNr ="ZZZ567";
      bil2.Bilmärke = "Ford";
      bil3.RegNr ="WAT057";
      bil3.Bilmärke = "Renault";
    }
  }
}