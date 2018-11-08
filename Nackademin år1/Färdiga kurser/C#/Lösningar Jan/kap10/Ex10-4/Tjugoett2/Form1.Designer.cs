namespace Tjugoett2 {
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
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.nyttKortKnapp = new System.Windows.Forms.Button();
      this.nyttSpelKnapp = new System.Windows.Forms.Button();
      this.stoppKnapp = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 12);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(552, 103);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 131);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(552, 103);
      this.flowLayoutPanel2.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(17, 252);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Din poäng:";
      // 
      // nyttKortKnapp
      // 
      this.nyttKortKnapp.Location = new System.Drawing.Point(20, 290);
      this.nyttKortKnapp.Name = "nyttKortKnapp";
      this.nyttKortKnapp.Size = new System.Drawing.Size(80, 29);
      this.nyttKortKnapp.TabIndex = 3;
      this.nyttKortKnapp.Text = "Ett kort till";
      this.nyttKortKnapp.UseVisualStyleBackColor = true;
      this.nyttKortKnapp.Click += new System.EventHandler(this.nyttKortKnapp_Click);
      // 
      // nyttSpelKnapp
      // 
      this.nyttSpelKnapp.Location = new System.Drawing.Point(233, 290);
      this.nyttSpelKnapp.Name = "nyttSpelKnapp";
      this.nyttSpelKnapp.Size = new System.Drawing.Size(80, 29);
      this.nyttSpelKnapp.TabIndex = 4;
      this.nyttSpelKnapp.Text = "Nytt spel";
      this.nyttSpelKnapp.UseVisualStyleBackColor = true;
      this.nyttSpelKnapp.Click += new System.EventHandler(this.nyttSpelKnapp_Click);
      // 
      // stoppKnapp
      // 
      this.stoppKnapp.Location = new System.Drawing.Point(122, 290);
      this.stoppKnapp.Name = "stoppKnapp";
      this.stoppKnapp.Size = new System.Drawing.Size(80, 29);
      this.stoppKnapp.TabIndex = 5;
      this.stoppKnapp.Text = "Stopp";
      this.stoppKnapp.UseVisualStyleBackColor = true;
      this.stoppKnapp.Click += new System.EventHandler(this.stoppKnapp_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(556, 331);
      this.Controls.Add(this.stoppKnapp);
      this.Controls.Add(this.nyttSpelKnapp);
      this.Controls.Add(this.nyttKortKnapp);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.flowLayoutPanel2);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Tjugoett";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button nyttKortKnapp;
    private System.Windows.Forms.Button nyttSpelKnapp;
    private System.Windows.Forms.Button stoppKnapp;
  }
}

