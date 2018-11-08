using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex9_6 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      Nytt();
    }

    private Slumpord o = new Slumpord("ord.txt");
    private string okäntOrd, ordet, visatOrd;
    private int antalFel, maxFel;

    private void Nytt() {
      ordet = o.EttOrd(); 
      okäntOrd = ordet;
      // låt visatOrd innehålla ordet.Length st frågetecken 
      visatOrd = "";
      for (int i=0; i<ordet.Length; i++)
        visatOrd = visatOrd + '?';
      label1.ForeColor = Color.Black;
      label1.Text = visatOrd;
      textBox1.Text = "";
      progressBar1.Value = 0; 
      antalFel=0;
      maxFel = ordet.Length;
    } 

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
      if (visatOrd == ordet) // ordet klart, börja på ett nytt
        Nytt();    
      else {
        char c = e.KeyChar;                        // ny bokstav
        int i = okäntOrd.IndexOf(c);               // finns den i ordet?
        if (i == -1) {                              // nej!
          if (++antalFel <= maxFel) 
            progressBar1.Value = 100 * antalFel/maxFel;
          if (antalFel == maxFel) {                  // för många felgissningar 
            label1.ForeColor = Color.Red;
            visatOrd = ordet;                       // visa det rätta ordet
          }
        }
        else {  // ja!
          while (i >= 0) {
            // flytta bokstaven från okäntOrd till visatOrd
            okäntOrd = okäntOrd.Substring(0, i) + '*' + okäntOrd.Substring(i + 1);
            visatOrd = visatOrd.Substring(0, i) + c + visatOrd.Substring(i + 1);
            i = okäntOrd.IndexOf(c);    // finns bokstaven flera gånger?
          }
        }
        label1.Text = visatOrd; 
      }
    }
  }
}