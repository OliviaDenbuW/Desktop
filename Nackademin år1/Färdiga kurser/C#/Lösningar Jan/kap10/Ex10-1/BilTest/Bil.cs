using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BilTest {
  public partial class Bil : UserControl {
    public Bil() {
      InitializeComponent();
    }

    public Bil(string nr, string fabrikat) : this() {
      RegNr = nr;
      Bilm�rke = fabrikat;
    }

    string regNr;
    string bilm�rke;
    Bil�gare �gare;

    public override string ToString() {
      return regNr + " " + bilm�rke;
    }

    public string RegNr {
      get { return regNr; }
      set { regNr = value; label1.Text = value; }
    }

    public string Bilm�rke {
      get { return bilm�rke; }
      set { bilm�rke = value; label2.Text = value; }
    }

    public Bil�gare �gare {
      get { return �gare; }
    }

    public void S�ld() {   // skall endast anropas av bilens �gare
      �gare = null;
    }

    public void K�pt(Bil�gare ny�gare) {  // skall endast anropas av bilens �gare
      �gare = ny�gare;
    }
  }
}
