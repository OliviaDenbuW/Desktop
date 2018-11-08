using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Signal {
  public partial class Trafikljus : UserControl {
    public Trafikljus() {
      InitializeComponent();
      timer1.Start();
    }

    SolidBrush[] b = { new SolidBrush(Color.Black), new SolidBrush(Color.Black), new SolidBrush(Color.Black) };
    Color[] col = { Color.Red, Color.Yellow, Color.Green };
    int[] intervall = new int[] { 5000, 2000, 8000 };
    int[] nr = { 0, 1, 2, 1 };
    int n = 3;   // aktuell fas

    protected override void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);
      Graphics g = e.Graphics;
      g.FillEllipse(b[0], 0, 0, ClientSize.Width, ClientSize.Width);
      g.FillEllipse(b[1], 0, ClientSize.Width + 3, ClientSize.Width, ClientSize.Width);
      g.FillEllipse(b[2], 0, 2*(ClientSize.Width + 3), ClientSize.Width, ClientSize.Width);
    }

    private void timer1_Tick(object sender, EventArgs e) {
      b[nr[n]].Color = Color.Black;
      n = (n+1) % 4;
      timer1.Interval = intervall[nr[n]];
      b[nr[n]].Color = col[nr[n]];
      Refresh();
    }
  }
}
