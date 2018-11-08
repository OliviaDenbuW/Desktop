using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ritare {
  public partial class Ritare : UserControl {
    public Ritare() {
      InitializeComponent();
      penna = new Pen(ForeColor);
    }

    List<Line> linjer = new List<Line>();   // linjerna i figuren
    Line nyLinje;               // linjen som skall läggas till
    ColorDialog d = new ColorDialog();
    Pen penna;
    bool vänsterNere = false;      // är vänster musknapp är nere?

    public void ÄndraFärg() {
      if (d.ShowDialog() == DialogResult.OK)
        ForeColor = d.Color;
    }

    private void RitaLinjer(Graphics g) {   // rita alla linjerna
      foreach (Line l in linjer) {
        penna.Color = l.Color;
        g.DrawLine(penna, l.P1, l.P2);
      }
    }

    protected override void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);
      RitaLinjer(e.Graphics);
    }

    private void Ritare_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left) {
        nyLinje = new Line(e.Location, e.Location, ForeColor);
        vänsterNere = true;
      }
      else if (e.Button == MouseButtons.Right && !vänsterNere)
        ÄndraFärg();
    }

    private void Ritare_MouseUp(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left) {
        nyLinje.P2 = e.Location;     // uppdatera slutpunkten
        linjer.Add(nyLinje);           // lägg till den nya linjen
        Refresh();                   // rita om
        vänsterNere = false;
      }
    }

    private void Ritare_MouseMove(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left) {
        Graphics g = CreateGraphics();       // skapa rityta
        penna.Color = BackColor;
        g.DrawLine(penna, nyLinje.P1, nyLinje.P2);  // sudda linjen
        nyLinje.P2 = e.Location;             // uppdatera slutpunkt
        penna.Color = nyLinje.Color;
        g.DrawLine(penna, nyLinje.P1, nyLinje.P2);  // rita linjen
        RitaLinjer(g);                       // rita övriga linjer
        g.Dispose();                         // frisläpp rityta
      }
    }

    private void Ritare_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar==(char)Keys.Back && linjer.Count>0 && !vänsterNere) {
        linjer.RemoveAt(linjer.Count-1);   // ta bort den sista linjen
        Refresh();                         // rita om
      }
    }

    public void Spara(string filnamn) {
      StreamWriter f = new StreamWriter(filnamn, false);
      foreach (Line l in linjer)
        f.WriteLine(l.P1.X + " " + l.P1.Y + " " +
                    l.P2.X + " " + l.P2.Y + " " +
                    l.Color.R + " " + l.Color.G + " " + l.Color.B);
      f.Close();
    }

    public void Öppna(string filnamn) {
      StreamReader f = new StreamReader(filnamn);
      linjer.Clear();
      while(true) {
        string rad = f.ReadLine();
        if (rad == null)
          break;
        string[] a = rad.Split();
        Point q1 = new Point(int.Parse(a[0]), int.Parse(a[1]));
        Point q2 = new Point(int.Parse(a[2]), int.Parse(a[3]));
        Color c = Color.FromArgb(int.Parse(a[4]), int.Parse(a[5]), int.Parse(a[6]));
        linjer.Add(new Line(q1, q2, c));
      }
      Refresh();
      f.Close();
    }
  }
}