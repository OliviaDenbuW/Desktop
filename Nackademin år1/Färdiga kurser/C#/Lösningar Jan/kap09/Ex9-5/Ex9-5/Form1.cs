using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex9_5 {
  public partial class Form1 : Form {
    Random rand = new Random();
    static int[,] vinnare = {{0, 1, 2},
                              {2, 0, 1},
                              {1, 2, 0}};
    Button[] datorKnappar;
    int antalVinst = 0;
    int antalFörlust = 0;

    public Form1() {
      InitializeComponent();
      datorKnappar = new Button[]{sten2, sax2, påse2};
    }

    private void CommonClick(int dittVal) {
      for (int i = 0; i < 3; i++)
        datorKnappar[i].UseVisualStyleBackColor = true;
      int datornsVal = rand.Next(3);
      Button dKnapp = datorKnappar[datornsVal];
      dKnapp.BackColor = Color.Yellow;
      int v = vinnare[dittVal, datornsVal];
      if (v==0) 
        meddelande.Text = "Oavgjort! Gör ett nytt val!";
      else if (v==1) {
        vinstMedd.Text = "Antal vinster: " + ++antalVinst;
        meddelande.Text = "Du vann! Gör ett nytt val!";
      }
      else  {
        förlustMedd.Text = "Antal vinster: " + ++antalFörlust;
        meddelande.Text = "Du förlorade! Gör ett nytt val!";
      }
    }

    private void sten1_Click(object sender, EventArgs e) {
      CommonClick(0);
    }

    private void sax1_Click(object sender, EventArgs e) {
      CommonClick(1);
    }

    private void påse1_Click(object sender, EventArgs e) {
      CommonClick(2);
    }
  }
}