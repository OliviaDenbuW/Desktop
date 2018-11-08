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

    private void anvisningarToolStripMenuItem_Click(object sender, EventArgs e) {
      MessageBox.Show("Håll nere vänster musknapp och dra musen");
    }

    private void väljaFärgToolStripMenuItem_Click(object sender, EventArgs e) {
      MessageBox.Show("Tryck ner höger musknapp");
    }
  }
}