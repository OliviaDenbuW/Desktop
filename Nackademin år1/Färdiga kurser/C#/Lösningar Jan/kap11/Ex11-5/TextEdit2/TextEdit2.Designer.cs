namespace TextEdit2 {
  partial class TextEdit2 {
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nyttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fönsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.fönsterToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.MdiWindowListItem = this.fönsterToolStripMenuItem;
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(292, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // arkivToolStripMenuItem
      // 
      this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttToolStripMenuItem,
            this.avslutaToolStripMenuItem});
      this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
      this.arkivToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.arkivToolStripMenuItem.Text = "Arkiv";
      // 
      // nyttToolStripMenuItem
      // 
      this.nyttToolStripMenuItem.Name = "nyttToolStripMenuItem";
      this.nyttToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.nyttToolStripMenuItem.Text = "Nytt";
      this.nyttToolStripMenuItem.Click += new System.EventHandler(this.nyttToolStripMenuItem_Click);
      // 
      // avslutaToolStripMenuItem
      // 
      this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
      this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.avslutaToolStripMenuItem.Text = "Avsluta";
      this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
      // 
      // fönsterToolStripMenuItem
      // 
      this.fönsterToolStripMenuItem.Name = "fönsterToolStripMenuItem";
      this.fönsterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.fönsterToolStripMenuItem.Text = "Fönster";
      // 
      // TextEdit2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "TextEdit2";
      this.Text = "TextEdit2";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nyttToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fönsterToolStripMenuItem;
  }
}