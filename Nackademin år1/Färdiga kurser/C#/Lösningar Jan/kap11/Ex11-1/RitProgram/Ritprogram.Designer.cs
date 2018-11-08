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
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.anvisningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.väljaFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem1});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(292, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anvisningarToolStripMenuItem,
            this.väljaFärgToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
      this.toolStripMenuItem1.Text = "Hjälp";
      // 
      // anvisningarToolStripMenuItem
      // 
      this.anvisningarToolStripMenuItem.Name = "anvisningarToolStripMenuItem";
      this.anvisningarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.anvisningarToolStripMenuItem.Text = "Rita linjer";
      this.anvisningarToolStripMenuItem.Click += new System.EventHandler(this.anvisningarToolStripMenuItem_Click);
      // 
      // väljaFärgToolStripMenuItem
      // 
      this.väljaFärgToolStripMenuItem.Name = "väljaFärgToolStripMenuItem";
      this.väljaFärgToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.väljaFärgToolStripMenuItem.Text = "Välja färg";
      this.väljaFärgToolStripMenuItem.Click += new System.EventHandler(this.väljaFärgToolStripMenuItem_Click);
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
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem anvisningarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem väljaFärgToolStripMenuItem;
  }
}

