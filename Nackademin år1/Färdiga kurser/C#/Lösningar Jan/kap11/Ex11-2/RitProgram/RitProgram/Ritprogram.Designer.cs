namespace RitProgram {
  partial class Ritprogram {
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
      this.ritare1 = new Ritare.Ritare();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ritare1
      // 
      this.ritare1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ritare1.Location = new System.Drawing.Point(0, 24);
      this.ritare1.Name = "ritare1";
      this.ritare1.Size = new System.Drawing.Size(292, 242);
      this.ritare1.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(292, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // arkivToolStripMenuItem
      // 
      this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.avslutaToolStripMenuItem});
      this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
      this.arkivToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.arkivToolStripMenuItem.Text = "Arkiv";
      // 
      // öppnaToolStripMenuItem
      // 
      this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
      this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.öppnaToolStripMenuItem.Text = "Öppna";
      this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
      // 
      // sparaToolStripMenuItem
      // 
      this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
      this.sparaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.sparaToolStripMenuItem.Text = "Spara";
      this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
      // 
      // avslutaToolStripMenuItem
      // 
      this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
      this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.avslutaToolStripMenuItem.Text = "Avsluta";
      this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // Ritprogram
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.ritare1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Ritprogram";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Ritare.Ritare ritare1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  }
}

