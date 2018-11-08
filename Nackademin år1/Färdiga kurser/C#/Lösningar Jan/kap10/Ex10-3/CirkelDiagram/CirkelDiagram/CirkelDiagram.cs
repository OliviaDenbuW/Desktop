using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CirkelDiagram {
  public partial class CirkelDiagram : UserControl {
    public CirkelDiagram() {
      InitializeComponent();
    }

    double procent;

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
      Pen pen = new Pen(ForeColor);
      int diam = Math.Min(ClientSize.Width-1, ClientSize.Height-1);
      int fylldDel = (int)Math.Round(procent * 0.01 * 360);
      g.FillPie(brush, (ClientSize.Width-diam)/2, (ClientSize.Height-diam)/2,
                    diam, diam, -90, fylldDel);
      g.DrawEllipse(pen, (ClientSize.Width-diam)/2, (ClientSize.Height-diam)/2,
       diam, diam);
    }
  }
}