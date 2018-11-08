using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AnalogKlocka {
  public partial class Klocka : UserControl {
    public Klocka() {
      InitializeComponent();
      timer1.Interval = 1000;
      timer1.Start();
    }

    int r, xTim, yTim, xMin, yMin, xSek, ySek;
    Brush whiteBrush = new SolidBrush(Color.White);
    Pen blackPen = new Pen(Color.Black);
    Pen redPen   = new Pen(Color.Red);

    private void timer1_Tick(object sender, EventArgs e) {
      r=Math.Min(ClientSize.Width, ClientSize.Height)/2-5;   // lämna en ram runt klockan
      DateTime nu = DateTime.Now;
      int tim = nu.Hour; ;
      int min = nu.Minute;
      int sek = nu.Second;
      // beräkna koordinater för timvisaren
      double v = Math.PI/2 - (tim+min/60.0)/12*2*Math.PI;
      xTim =  (int)Math.Round(r/2.0*Math.Cos(v));
      yTim = -(int)Math.Round(r/2.0*Math.Sin(v));
      // beräkna koordinater för minutvisaren
      v = Math.PI/2 - (min+sek/60.0)/60*2*Math.PI;
      xMin =  (int)Math.Round(r*Math.Cos(v));
      yMin = -(int)Math.Round(r*Math.Sin(v));
      // beräkna koordinater för sekundvisaren
      v = Math.PI/2 - sek/60.0*2*Math.PI;
      xSek =  (int)Math.Round(r*Math.Cos(v));
      ySek = -(int)Math.Round(r*Math.Sin(v));
      Refresh();
    }

    protected override void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);
      Graphics g = e.Graphics;
      g.ResetTransform();
      g.TranslateTransform(ClientSize.Width/2, ClientSize.Height/2);
      g.FillEllipse(whiteBrush, -r, -r, 2*r, 2*r); // rita vit urtavla
      g.DrawLine(blackPen, 0, 0, xTim, yTim);
      g.DrawLine(blackPen, 0, 0, xMin, yMin);
      g.DrawLine(redPen, 0, 0, xSek, ySek);
    }
  }
}
