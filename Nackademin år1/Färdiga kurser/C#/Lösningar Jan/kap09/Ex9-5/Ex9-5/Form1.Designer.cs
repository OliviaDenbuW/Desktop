namespace Ex9_5 {
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
      this.sten1 = new System.Windows.Forms.Button();
      this.sax1 = new System.Windows.Forms.Button();
      this.påse1 = new System.Windows.Forms.Button();
      this.påse2 = new System.Windows.Forms.Button();
      this.sax2 = new System.Windows.Forms.Button();
      this.sten2 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.meddelande = new System.Windows.Forms.Label();
      this.vinstMedd = new System.Windows.Forms.Label();
      this.förlustMedd = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(10, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ditt val:";
      // 
      // sten1
      // 
      this.sten1.Location = new System.Drawing.Point(92, 21);
      this.sten1.Name = "sten1";
      this.sten1.Size = new System.Drawing.Size(64, 24);
      this.sten1.TabIndex = 1;
      this.sten1.Text = "Sten";
      this.sten1.UseVisualStyleBackColor = true;
      this.sten1.Click += new System.EventHandler(this.sten1_Click);
      // 
      // sax1
      // 
      this.sax1.Location = new System.Drawing.Point(162, 21);
      this.sax1.Name = "sax1";
      this.sax1.Size = new System.Drawing.Size(64, 24);
      this.sax1.TabIndex = 2;
      this.sax1.Text = "Sax";
      this.sax1.UseVisualStyleBackColor = true;
      this.sax1.Click += new System.EventHandler(this.sax1_Click);
      // 
      // påse1
      // 
      this.påse1.Location = new System.Drawing.Point(232, 21);
      this.påse1.Name = "påse1";
      this.påse1.Size = new System.Drawing.Size(64, 24);
      this.påse1.TabIndex = 3;
      this.påse1.Text = "Påse";
      this.påse1.UseVisualStyleBackColor = true;
      this.påse1.Click += new System.EventHandler(this.påse1_Click);
      // 
      // påse2
      // 
      this.påse2.Enabled = false;
      this.påse2.Location = new System.Drawing.Point(232, 59);
      this.påse2.Name = "påse2";
      this.påse2.Size = new System.Drawing.Size(64, 24);
      this.påse2.TabIndex = 7;
      this.påse2.Text = "Påse";
      this.påse2.UseVisualStyleBackColor = true;
      // 
      // sax2
      // 
      this.sax2.Enabled = false;
      this.sax2.Location = new System.Drawing.Point(162, 59);
      this.sax2.Name = "sax2";
      this.sax2.Size = new System.Drawing.Size(64, 24);
      this.sax2.TabIndex = 6;
      this.sax2.Text = "Sax";
      this.sax2.UseVisualStyleBackColor = true;
      // 
      // sten2
      // 
      this.sten2.Enabled = false;
      this.sten2.Location = new System.Drawing.Point(92, 59);
      this.sten2.Name = "sten2";
      this.sten2.Size = new System.Drawing.Size(64, 24);
      this.sten2.TabIndex = 5;
      this.sten2.Text = "Sten";
      this.sten2.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(10, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Datorns val:";
      // 
      // meddelande
      // 
      this.meddelande.AutoSize = true;
      this.meddelande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.meddelande.Location = new System.Drawing.Point(112, 115);
      this.meddelande.Name = "meddelande";
      this.meddelande.Size = new System.Drawing.Size(89, 13);
      this.meddelande.TabIndex = 8;
      this.meddelande.Text = "Välj en knapp!";
      // 
      // vinstMedd
      // 
      this.vinstMedd.AutoSize = true;
      this.vinstMedd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vinstMedd.Location = new System.Drawing.Point(10, 158);
      this.vinstMedd.Name = "vinstMedd";
      this.vinstMedd.Size = new System.Drawing.Size(93, 13);
      this.vinstMedd.TabIndex = 9;
      this.vinstMedd.Text = "Antal vinster: 0";
      // 
      // förlustMedd
      // 
      this.förlustMedd.AutoSize = true;
      this.förlustMedd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.förlustMedd.Location = new System.Drawing.Point(182, 158);
      this.förlustMedd.Name = "förlustMedd";
      this.förlustMedd.Size = new System.Drawing.Size(101, 13);
      this.förlustMedd.TabIndex = 10;
      this.förlustMedd.Text = "Antal förluster: 0";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(321, 193);
      this.Controls.Add(this.förlustMedd);
      this.Controls.Add(this.vinstMedd);
      this.Controls.Add(this.meddelande);
      this.Controls.Add(this.påse2);
      this.Controls.Add(this.sax2);
      this.Controls.Add(this.sten2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.påse1);
      this.Controls.Add(this.sax1);
      this.Controls.Add(this.sten1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Ex9-5";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button sten1;
    private System.Windows.Forms.Button sax1;
    private System.Windows.Forms.Button påse1;
    private System.Windows.Forms.Button påse2;
    private System.Windows.Forms.Button sax2;
    private System.Windows.Forms.Button sten2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label meddelande;
    private System.Windows.Forms.Label vinstMedd;
    private System.Windows.Forms.Label förlustMedd;
  }
}

