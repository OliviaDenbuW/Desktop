namespace Keyboard {
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
      this.tabParent = new System.Windows.Forms.Panel();
      this.displayLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tabParent
      // 
      this.tabParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabParent.Location = new System.Drawing.Point(0, 40);
      this.tabParent.Name = "tabParent";
      this.tabParent.Size = new System.Drawing.Size(481, 164);
      this.tabParent.TabIndex = 0;
      // 
      // displayLabel
      // 
      this.displayLabel.AutoSize = true;
      this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.displayLabel.Location = new System.Drawing.Point(12, 9);
      this.displayLabel.Name = "displayLabel";
      this.displayLabel.Size = new System.Drawing.Size(0, 16);
      this.displayLabel.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 203);
      this.Controls.Add(this.displayLabel);
      this.Controls.Add(this.tabParent);
      this.Name = "Form1";
      this.Text = "Keyboard";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel tabParent;
    private System.Windows.Forms.Label displayLabel;
  }
}

