using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tjugoett2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      lek = new Kortbunt();
      du  = new Människa(lek);
      jag = new Dator(lek, du);
      InitSpel();
    }

    Kortbunt lek;
    Människa du; 
    Dator jag;

    private void InitSpel() {
      lek.NyKortlek();
      lek.Blanda();
      flowLayoutPanel1.Controls.Clear();
      flowLayoutPanel2.Controls.Clear();
      du.Spela();
      flowLayoutPanel1.Controls.Add(du.hand[0]);
      label1.Text = "Din poäng: " + du.Poäng + ". ";
      nyttKortKnapp.Enabled = true;
      stoppKnapp.Enabled = true;
      nyttSpelKnapp.Enabled = false;
      nyttKortKnapp.Focus();
    }

    private void nyttSpelKnapp_Click(object sender, EventArgs e) {
      InitSpel();
    }

    private void nyttKortKnapp_Click(object sender, EventArgs e) {
      du.NyttKort();
      flowLayoutPanel1.Controls.Add(du.hand[0]);
      label1.Text = "Din poäng: " + du.Poäng + ". ";
      if (du.Poäng >= 21)
        stoppKnapp.PerformClick();
    }

    private void stoppKnapp_Click(object sender, EventArgs e) {
      nyttKortKnapp.Enabled = false;
      stoppKnapp.Enabled = false;
      label1.Text = "Din poäng: " + du.Poäng + ". ";
      if (du.Poäng > 21)
        label1.Text += "Du förlorade!";
      else if (du.Poäng == 21)
        label1.Text += "Du vann!";
      else { // datorn måste spela
        jag.Spela();
        for (int i=0; i < jag.hand.AntalKort; i++ )
          flowLayoutPanel2.Controls.Add(jag.hand[i]);
        label1.Text += "Datorns poäng: " + jag.Poäng + ". ";
        if (jag.Poäng <= 21 && jag.Poäng >= du.Poäng)
          label1.Text += "Du förlorade!";
        else
          label1.Text += "Du vann!";
      }
      nyttSpelKnapp.Enabled = true;
      nyttSpelKnapp.Focus();
    }
  }
}