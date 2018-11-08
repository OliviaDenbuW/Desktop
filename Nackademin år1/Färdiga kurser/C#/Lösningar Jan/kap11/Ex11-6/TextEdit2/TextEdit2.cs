using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextEdit2 {
  public partial class TextEdit2 : Form {
    string searched;
    ReplaceDialog dialog = new ReplaceDialog();

    public TextEdit2() {
      InitializeComponent();
      dialog.editForm = this;
     }

    private void newMenuItem_Click(object sender, EventArgs e) {
      if (area.Modified)
        saveOldText();
      area.Text = "";       // Töm arean
      Text = "";            // Ta bort filnamn från fönsterramen
      area.Modified = false;
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

    private void findMenuItem_Click(object sender, EventArgs e) {
      searched = InputBox.Show("Sökt text?", "Sök", searched);
      dialog.setNext(searched);
      if (!Find())
        MessageBox.Show("Fanns ej");
    }

    private void findNextlMenuItem_Click(object sender, EventArgs e) {
      if (!Find())
        MessageBox.Show("Fanns ej");
    }

    private void replaceMenuItem_Click(object sender, EventArgs e) {
      dialog.Visible = true;
    }

    public bool Find() {
      if (searched != null) {
        int k = area.SelectionStart + area.SelectionLength;   // börja söka på plats nr k
        int i = area.Text.IndexOf(searched, k);
        if (i>=0) {
          area.Select(i, searched.Length);
          return true;
        }
        else {
          return false;
        }
      }
      else
        return false;
    }

    public void Replace(string newText) {
      int i = area.SelectionStart;
      if (area.SelectionLength > 0) {
        area.Text = area.Text.Substring(0, i) + newText + 
                    area.Text.Substring(i+area.SelectionLength);
        area.SelectionStart = i + newText.Length;
        area.SelectionStart = 0;
      }
    }

    public void ReplaceAll(string newText) {
      while (Find())
        Replace(newText);
    }

    public string Searched {
      get { return searched; }
      set { area.DeselectAll(); searched = value; }
    }

  }
}