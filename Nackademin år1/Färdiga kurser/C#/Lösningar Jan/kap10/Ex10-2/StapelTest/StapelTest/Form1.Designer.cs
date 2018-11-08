namespace StapelTest {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.stapel1 = new Stapel.Stapel();
      this.stapel2 = new Stapel.Stapel();
      this.SuspendLayout();
      // 
      // stapel1
      // 
      this.stapel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stapel1.ForeColor = System.Drawing.Color.Red;
      this.stapel1.Location = new System.Drawing.Point(31, 37);
      this.stapel1.Name = "stapel1";
      this.stapel1.Procent = 0;
      this.stapel1.Size = new System.Drawing.Size(27, 150);
      this.stapel1.TabIndex = 0;
      this.stapel1.Vertikal = true;
      // 
      // stapel2
      // 
      this.stapel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stapel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.stapel2.Location = new System.Drawing.Point(67, 225);
      this.stapel2.Name = "stapel2";
      this.stapel2.Procent = 0;
      this.stapel2.Size = new System.Drawing.Size(156, 29);
      this.stapel2.TabIndex = 1;
      this.stapel2.Vertikal = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.stapel2);
      this.Controls.Add(this.stapel1);
      this.Name = "Form1";
      this.Text = "StapelTest";
      this.ResumeLayout(false);

    }

    #endregion

    private Stapel.Stapel stapel1;
    private Stapel.Stapel stapel2;
  }
}

