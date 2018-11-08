using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RitProgram {
  public partial class Ritprogram : Form {
    public Ritprogram() {
      InitializeComponent();
    }

    private void öppnaToolStripMenuItem_Click(object sender, EventArgs e) {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
        ritare1.Öppna(openFileDialog1.FileName); 

    }

    private void sparaToolStripMenuItem_Click(object sender, EventArgs e) {
      saveFileDialog1.FileName = "";
      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        ritare1.Spara(saveFileDialog1.FileName);
    }

    private void avslutaToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }
  }
}