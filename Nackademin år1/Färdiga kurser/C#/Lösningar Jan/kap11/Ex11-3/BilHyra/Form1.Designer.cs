﻿namespace BilHyra {
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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
      this.button3 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Växlingskurs?";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Antal dagar?";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Pris per dag?";
      this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(103, 10);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 3;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(103, 40);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 4;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(103, 72);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 5;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(16, 114);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Rensa";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(128, 114);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "Beräkna";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 156);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Totalt pris:";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // errorProvider2
      // 
      this.errorProvider2.ContainerControl = this;
      // 
      // errorProvider3
      // 
      this.errorProvider3.ContainerControl = this;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(72, 182);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 9;
      this.button3.Text = "Nytt Fönster";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.button2;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(227, 217);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "BilHyra";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.ErrorProvider errorProvider2;
    private System.Windows.Forms.ErrorProvider errorProvider3;
    private System.Windows.Forms.Button button3;
  }
}

