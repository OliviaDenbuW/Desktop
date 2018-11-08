using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextEdit2 {
  public partial class TextEdit2 : Form {
    static int totAntal = 0;

    public TextEdit2() {
      InitializeComponent();
      totAntal++;
      Visible = true;
     }

    private void newMenuItem_Click(object sender, EventArgs e) {
      new TextEdit2();
    }

    private void openMenuItem_Click(object sender, EventArgs e) {
      if (area.Modified)
        saveOldText();
      if (openDialog.ShowDialog() == DialogResult.OK) {
        area.LoadFile(openDialog.FileName,
                      RichTextBoxStreamType.PlainText);
        Text = openDialog.FileName;  // Visa filnamn i fönsterramen
        area.Modified = false;
      }
    }

    private void saveAsMenuItem_Click(object sender, EventArgs e) {
      saveAsDialog.FileName = "";
      if (saveAsDialog.ShowDialog() == DialogResult.OK) {
        area.SaveFile(saveAsDialog.FileName, RichTextBoxStreamType.PlainText);
        Text = saveAsDialog.FileName; // Visa filnamn i fönsterramen
        area.Modified = false;
      }
    }

    private void saveMenuItem_Click(object sender, EventArgs e) {
      if (Text != "")       // Finns filnamn i fönsterramen?
        area.SaveFile(Text, RichTextBoxStreamType.PlainText);
      else                  // Utför "Spara som" istället
        saveAsMenuItem_Click(null, null);
      area.Modified = false;
    }

    private void exitMenuItem_Click(object sender, EventArgs e) {
      if (area.Modified)
        saveOldText();
      Application.Exit();
    }

    // Hjälpmetod
    private void saveOldText() {
      string s;
      if (Text != "")    // Finns filnamn i fönsterramen?
        s = "Skall ändringarna sparas i filen " + Text +"?";
      else
        s = "Skall texten sparas?";
      if (MessageBox.Show(s, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
        saveMenuItem_Click(null, null);
    }

    private void cutMenuItem_Click(object sender, EventArgs e) {
      area.Cut();
    }

    private void copyMenuItem_Click(object sender, EventArgs e) {
      area.Copy();
    }

    private void pasteMenuItem_Click(object sender, EventArgs e) {
      area.Paste();
    }

    private void TextEdit2_FormClosed(object sender, FormClosedEventArgs e) {
      if (area.Modified)
        saveOldText();
      if (--totAntal == 0)
        Application.Exit();
    }
  }
}