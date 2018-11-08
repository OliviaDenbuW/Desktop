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
    int höjd;          // anger hur högt bollen studsar
    double minskning;  // anger hur många procent höjden minskar
    Brush brush = new SolidBrush(Color.Red);

    public int Radie { set { r = value; diam = 2*r; } }
    public int Hastighet { set { ySteg = value; } }
    public double HöjdMinskning { set { minskning = value;} }

    public void Starta() {
      // placera bollen längst upp
      x = ClientSize.Width/2;
      y = r;
      höjd = ClientSize.Height;
      timer1.Start();
      Refresh();
    }

    public void Stoppa() {
      // placera bollen längst ner
      y = ClientSize.Height-r;
      timer1.Stop();
      Refresh();
    }

    private void timer1_Tick(object sender, EventArgs e) {
      if (y+r+ySteg > ClientSize.Height) {      // längst ner?
        y = ClientSize.Height-r;  // studsa precis på kanten
        ySteg = -ySteg;           // byt riktning
        höjd = (int)((100-minskning)/100*höjd);  // minska höjden
        if (höjd <= r)
          Stoppa();
      }
      else {
        if (y-r+ySteg < ClientSize.Height-höjd)  // uppe?
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
