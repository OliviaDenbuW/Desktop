using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextEdit2 {
  public partial class ReplaceDialog : Form {

    public TextEdit2 editForm;

    public ReplaceDialog() {
      InitializeComponent();
    }

    public void setNext(string s) {
      textBox1.Text = s;
    }

    private void replaceButton_Click(object sender, EventArgs e) {
      editForm.Replace(textBox2.Text);
    }

    private void nextButton_Click(object sender, EventArgs e) {
      if (!editForm.Find())
          MessageBox.Show("Fanns ej");
      
    }

    private void replaceAllButton_Click(object sender, EventArgs e) {
      editForm.ReplaceAll(textBox2.Text);
    }

    private void closeButton_Click(object sender, EventArgs e) {
      Visible = false;
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
      editForm.Searched = textBox1.Text;
    }

  }
}