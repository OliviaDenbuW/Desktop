using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stapel {
  public partial class Stapel : UserControl {
    public Stapel() {
      InitializeComponent();
    }

    public Stapel(bool vert, double proc) : this() {
      Vertikal = vert;
      Procent = proc;
    }

    bool vertikal;
    double procent;

    public bool Vertikal {
      get { return vertikal; }
      set { vertikal = value; }
    }

    public double Procent {
      get { return procent; }
      set {
        if (value < 0 || value > 100)
          throw new ArgumentOutOfRangeException("value");
        procent = value;
        Refresh();
      }
    }

     protected override void OnPaint(PaintEventArgs e) {
       base.OnPaint(e);
       Graphics g = e.Graphics;
       Brush brush = new SolidBrush(ForeColor);
       if (vertikal) {
         int höjd = (int)(ClientSize.Height * procent /100);
         g.FillRectangle(brush, 0, ClientSize.Height-höjd, ClientSize.Width, höjd);
       }
       else {
         int bredd = (int)(ClientSize.Width * procent /100);
         g.FillRectangle(brush, 0, 0, bredd, ClientSize.Height);
       }
     }
  }
}