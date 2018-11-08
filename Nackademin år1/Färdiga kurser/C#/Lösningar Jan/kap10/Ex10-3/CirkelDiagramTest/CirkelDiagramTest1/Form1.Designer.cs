namespace CirkelDiagramTest {
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
      this.cirkelDiagram1 = new CirkelDiagram.CirkelDiagram();
      this.cirkelDiagram2 = new CirkelDiagram.CirkelDiagram();
      this.cirkelDiagram3 = new CirkelDiagram.CirkelDiagram();
      this.SuspendLayout();
      // 
      // cirkelDiagram1
      // 
      this.cirkelDiagram1.Location = new System.Drawing.Point(2, 3);
      this.cirkelDiagram1.Name = "cirkelDiagram1";
      this.cirkelDiagram1.Procent = 10;
      this.cirkelDiagram1.Size = new System.Drawing.Size(150, 150);
      this.cirkelDiagram1.TabIndex = 0;
      // 
      // cirkelDiagram2
      // 
      this.cirkelDiagram2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.cirkelDiagram2.ForeColor = System.Drawing.Color.Red;
      this.cirkelDiagram2.Location = new System.Drawing.Point(175, 3);
      this.cirkelDiagram2.Name = "cirkelDiagram2";
      this.cirkelDiagram2.Procent = 60;
      this.cirkelDiagram2.Size = new System.Drawing.Size(150, 150);
      this.cirkelDiagram2.TabIndex = 1;
      // 
      // cirkelDiagram3
      // 
      this.cirkelDiagram3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.cirkelDiagram3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.cirkelDiagram3.Location = new System.Drawing.Point(352, 3);
      this.cirkelDiagram3.Name = "cirkelDiagram3";
      this.cirkelDiagram3.Procent = 80;
      this.cirkelDiagram3.Size = new System.Drawing.Size(150, 150);
      this.cirkelDiagram3.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(514, 167);
      this.Controls.Add(this.cirkelDiagram3);
      this.Controls.Add(this.cirkelDiagram2);
      this.Controls.Add(this.cirkelDiagram1);
      this.Name = "Form1";
      this.Text = "Cirkeldiagram";
      this.ResumeLayout(false);

    }

    #endregion

    private CirkelDiagram.CirkelDiagram cirkelDiagram1;
    private CirkelDiagram.CirkelDiagram cirkelDiagram2;
    private CirkelDiagram.CirkelDiagram cirkelDiagram3;
  }
}

