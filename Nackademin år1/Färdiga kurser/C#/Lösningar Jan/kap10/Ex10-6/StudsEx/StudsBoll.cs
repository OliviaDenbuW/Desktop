using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StudsEx {
  public partial class StudsBoll : UserControl {
    public StudsBoll() {
      InitializeComponent();
    }

    int r;             // bollens radie
    int diam;
    int x, y;          // bollens mittpunkt
    int ySteg;         // bollens hastighet (antal bildpunkter/100 ms)
    int h�jd;          // anger hur h�gt bollen studsar
    double minskning;  // anger hur m�nga procent h�jden minskar
    Brush brush = new SolidBrush(Color.Red);

    public int Radie { set { r = value; diam = 2*r; } }
    public int Hastighet { set { ySteg = value; } }
    public double H�jdMinskning { set { minskning = value;} }

    public void Starta() {
      // placera bollen l�ngst upp
      x = ClientSize.Width/2;
      y = r;
      h�jd = ClientSize.Height;
      timer1.Start();
      Refresh();
    }

    public void Stoppa() {
      // placera bollen l�ngst ner
      y = ClientSize.Height-r;
      timer1.Stop();
      Refresh();
    }

    private void timer1_Tick(object sender, EventArgs e) {
      if (y+r+ySteg > ClientSize.Height) {      // l�ngst ner?
        y = ClientSize.Height-r;  // studsa precis p� kanten
        ySteg = -ySteg;           // byt riktning
        h�jd = (int)((100-minskning)/100*h�jd);  // minska h�jden
        if (h�jd <= r)
          Stoppa();
      }
      else {
        if (y-r+ySteg < ClientSize.Height-h�jd)  // uppe?
          ySteg = -ySteg;         // byt riktning
        y += ySteg;
      }
      Refresh();
    }

    protected override void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);
      Graphics g = e.Graphics;
      g.FillEllipse(brush, x-r, y-r, diam, diam);
    }
  }
}
