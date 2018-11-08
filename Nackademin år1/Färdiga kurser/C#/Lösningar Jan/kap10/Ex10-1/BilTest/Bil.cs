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
      Bilmärke = fabrikat;
    }

    string regNr;
    string bilmärke;
    Bilägare ägare;

    public override string ToString() {
      return regNr + " " + bilmärke;
    }

    public string RegNr {
      get { return regNr; }
      set { regNr = value; label1.Text = value; }
    }

    public string Bilmärke {
      get { return bilmärke; }
      set { bilmärke = value; label2.Text = value; }
    }

    public Bilägare Ägare {
      get { return ägare; }
    }

    public void Såld() {   // skall endast anropas av bilens ägare
      ägare = null;
    }

    public void Köpt(Bilägare nyÄgare) {  // skall endast anropas av bilens ägare
      ägare = nyÄgare;
    }
  }
}
