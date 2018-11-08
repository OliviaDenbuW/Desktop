using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex9_4 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {
      int c = trackBar1.Value;
      int f = (int)Math.Round(c * 9/5+32.0);
      label1.Text = c + " C";
      label2.Text = f + " F";
      // se till att de visade värdet inte hamnar utanför skalan
      f = Math.Max(f, trackBar2.Minimum);
      f = Math.Min(f, trackBar2.Maximum);
      trackBar2.Value = f;
    }

    private void trackBar2_Scroll(object sender, EventArgs e) {
      int f = trackBar2.Value;
      int c = (int)Math.Round((f-32.0)*5/9);
      label1.Text = c + " C";
      label2.Text = f + " F";
      // se till att de visade värdet inte hamnar utanför skalan
      c = Math.Max(c, trackBar1.Minimum);
      c = Math.Min(c, trackBar1.Maximum);
      trackBar1.Value = c;
    }
  }
}