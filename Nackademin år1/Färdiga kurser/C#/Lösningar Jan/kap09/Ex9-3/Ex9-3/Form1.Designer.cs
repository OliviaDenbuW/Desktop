namespace Ex9_3 {
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.labelMil = new System.Windows.Forms.Label();
      this.labelPerMil = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mätarställning idag?";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(152, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Mätarställning för ett år sedan?";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(179, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 2;
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(179, 45);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 3;
      this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 119);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(79, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Antal körda mil:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 149);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(99, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Förbrukning per mil:";
      // 
      // labelMil
      // 
      this.labelMil.AutoSize = true;
      this.labelMil.Location = new System.Drawing.Point(123, 119);
      this.labelMil.Name = "labelMil";
      this.labelMil.Size = new System.Drawing.Size(13, 13);
      this.labelMil.TabIndex = 8;
      this.labelMil.Text = "--";
      // 
      // labelPerMil
      // 
      this.labelPerMil.AutoSize = true;
      this.labelPerMil.Location = new System.Drawing.Point(123, 149);
      this.labelPerMil.Name = "labelPerMil";
      this.labelPerMil.Size = new System.Drawing.Size(13, 13);
      this.labelPerMil.TabIndex = 10;
      this.labelPerMil.Text = "--";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(179, 77);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 12;
      this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 80);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(90, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Antal liter bensin?";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(308, 178);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.labelPerMil);
      this.Controls.Add(this.labelMil);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Ex9-3";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label labelMil;
    private System.Windows.Forms.Label labelPerMil;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label6;

  }
}

