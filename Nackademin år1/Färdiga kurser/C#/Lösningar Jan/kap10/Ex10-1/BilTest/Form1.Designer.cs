namespace BilTest {
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
      this.bil1 = new BilTest.Bil();
      this.bil2 = new BilTest.Bil();
      this.bil3 = new BilTest.Bil();
      this.SuspendLayout();
      // 
      // bil1
      // 
      this.bil1.Bilmärke = null;
      this.bil1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.bil1.Location = new System.Drawing.Point(12, 12);
      this.bil1.Name = "bil1";
      this.bil1.RegNr = null;
      this.bil1.Size = new System.Drawing.Size(150, 81);
      this.bil1.TabIndex = 0;
      // 
      // bil2
      // 
      this.bil2.Bilmärke = null;
      this.bil2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.bil2.Location = new System.Drawing.Point(12, 103);
      this.bil2.Name = "bil2";
      this.bil2.RegNr = null;
      this.bil2.Size = new System.Drawing.Size(150, 80);
      this.bil2.TabIndex = 1;
      // 
      // bil3
      // 
      this.bil3.Bilmärke = null;
      this.bil3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.bil3.Location = new System.Drawing.Point(12, 189);
      this.bil3.Name = "bil3";
      this.bil3.RegNr = null;
      this.bil3.Size = new System.Drawing.Size(150, 86);
      this.bil3.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 281);
      this.Controls.Add(this.bil3);
      this.Controls.Add(this.bil2);
      this.Controls.Add(this.bil1);
      this.Name = "Form1";
      this.Text = "BilTest";
      this.ResumeLayout(false);

    }

    #endregion

    private Bil bil1;
    private Bil bil2;
    private Bil bil3;


  }
}

