namespace TextEdit2 {
  partial class ReplaceDialog {
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
      this.replaceButton = new System.Windows.Forms.Button();
      this.nextButton = new System.Windows.Forms.Button();
      this.replaceAllButton = new System.Windows.Forms.Button();
      this.closeButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "S�kt text:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Ers�tt med:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(94, 18);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(155, 20);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(94, 58);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(155, 20);
      this.textBox2.TabIndex = 3;
      // 
      // replaceButton
      // 
      this.replaceButton.Location = new System.Drawing.Point(12, 101);
      this.replaceButton.Name = "replaceButton";
      this.replaceButton.Size = new System.Drawing.Size(75, 23);
      this.replaceButton.TabIndex = 4;
      this.replaceButton.Text = "Ers�tt";
      this.replaceButton.UseVisualStyleBackColor = true;
      this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
      // 
      // nextButton
      // 
      this.nextButton.Location = new System.Drawing.Point(109, 101);
      this.nextButton.Name = "nextButton";
      this.nextButton.Size = new System.Drawing.Size(75, 23);
      this.nextButton.TabIndex = 5;
      this.nextButton.Text = "N�sta";
      this.nextButton.UseVisualStyleBackColor = true;
      this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
      // 
      // replaceAllButton
      // 
      this.replaceAllButton.Location = new System.Drawing.Point(205, 101);
      this.replaceAllButton.Name = "replaceAllButton";
      this.replaceAllButton.Size = new System.Drawing.Size(75, 23);
      this.replaceAllButton.TabIndex = 6;
      this.replaceAllButton.Text = "Ers�tt alla";
      this.replaceAllButton.UseVisualStyleBackColor = true;
      this.replaceAllButton.Click += new System.EventHandler(this.replaceAllButton_Click);
      // 
      // closeButton
      // 
      this.closeButton.Location = new System.Drawing.Point(205, 143);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 7;
      this.closeButton.Text = "St�ng";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // ReplaceDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 177);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.replaceAllButton);
      this.Controls.Add(this.nextButton);
      this.Controls.Add(this.replaceButton);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "ReplaceDialog";
      this.Text = "Ers�tt";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button replaceButton;
    private System.Windows.Forms.Button nextButton;
    private System.Windows.Forms.Button replaceAllButton;
    private System.Windows.Forms.Button closeButton;
  }
}