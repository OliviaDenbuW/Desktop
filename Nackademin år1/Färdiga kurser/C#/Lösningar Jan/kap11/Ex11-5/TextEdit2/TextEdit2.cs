using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextEdit2 {
  public partial class TextEdit2 : Form {
    public TextEdit2() {
      InitializeComponent();
    }

    public void nyttToolStripMenuItem_Click(object sender, EventArgs e) {
      Internt f = new Internt();
      f.MdiParent = this;
      f.Show();
    }

    private void avslutaToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

  }
}