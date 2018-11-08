using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Keyboard {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      initKeyboard();
    }

    TableLayoutPanel tab;
    const int R = 5;   // antal rader
    const int C = 12;  // antal kolumner

    private void initKeyboard() {
      tab = new TableLayoutPanel();
      tab.SuspendLayout();
      tab.Dock = DockStyle.Fill;
      tab.RowCount = R;
      tab.ColumnCount = C;
      float proc = 100F / R;
      for (int r=0; r<R; r++)
        tab.RowStyles.Add(new RowStyle(SizeType.Percent, proc));
      proc = 100F / C;
      for (int c=0; c<=C; c++)
        tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, proc));
      string[] s = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "+", "Del", 
                    "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "å", "~", 
                    "a", "s", "d", "f", "g", "h", "j", "k", "l", "ö", "ä", "*",
                    "z", "x", "c", "v", "b", "n", "m", ",", ".", ":", "\\", "Enter", 
                    " "};
      for (int i=0; i<s.Length; i++) {
        Button b = new Button();
        tab.Controls.Add(b, i%C, i/C);
        b.Text = s[i];
        b.Dock = DockStyle.Fill;
        b.Click += tabButton_Click;
      }

      Control ctr = tab.GetControlFromPosition(0, R-1);
      tab.SetColumnSpan(ctr, C);
      tabParent.Controls.Add(tab);
      tab.ResumeLayout();
    }

    private void tabButton_Click(object sender, EventArgs e) {
      Button b = (Button) sender;
      if (b.Text == "Enter") {
        Process.Start(displayLabel.Text);
        displayLabel.Text = "";
      }
      else if (b.Text == "Del" && displayLabel.Text.Length > 0)
        displayLabel.Text = displayLabel.Text.Substring(0, displayLabel.Text.Length-1);
      else
        displayLabel.Text += b.Text;
    }

  }


}