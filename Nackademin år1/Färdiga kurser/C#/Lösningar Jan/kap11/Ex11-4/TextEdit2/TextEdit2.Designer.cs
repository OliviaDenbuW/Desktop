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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEdit2));
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.area = new System.Windows.Forms.RichTextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.newButton = new System.Windows.Forms.ToolStripButton();
      this.openButton = new System.Windows.Forms.ToolStripButton();
      this.saveAsButton = new System.Windows.Forms.ToolStripButton();
      this.saveButton = new System.Windows.Forms.ToolStripButton();
      this.cutButton = new System.Windows.Forms.ToolStripButton();
      this.copyButton = new System.Windows.Forms.ToolStripButton();
      this.pasteButton = new System.Windows.Forms.ToolStripButton();
      this.openDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveAsDialog = new System.Windows.Forms.SaveFileDialog();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStripContainer1
      // 
      this.toolStripContainer1.BottomToolStripPanelVisible = false;
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.area);
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(292, 217);
      this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer1.LeftToolStripPanelVisible = false;
      this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.RightToolStripPanelVisible = false;
      this.toolStripContainer1.Size = new System.Drawing.Size(292, 266);
      this.toolStripContainer1.TabIndex = 0;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // toolStripContainer1.TopToolStripPanel
      // 
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
      // 
      // area
      // 
      this.area.Dock = System.Windows.Forms.DockStyle.Fill;
      this.area.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.area.Location = new System.Drawing.Point(0, 0);
      this.area.Name = "area";
      this.area.Size = new System.Drawing.Size(292, 217);
      this.area.TabIndex = 0;
      this.area.Text = "";
      this.area.WordWrap = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.redigeraToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(292, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // arkivToolStripMenuItem
      // 
      this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveAsMenuItem,
            this.saveMenuItem,
            this.exitMenuItem});
      this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
      this.arkivToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.arkivToolStripMenuItem.Text = "Arkiv";
      // 
      // newMenuItem
      // 
      this.newMenuItem.Name = "newMenuItem";
      this.newMenuItem.Size = new System.Drawing.Size(152, 22);
      this.newMenuItem.Text = "Ny";
      this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
      // 
      // openMenuItem
      // 
      this.openMenuItem.Name = "openMenuItem";
      this.openMenuItem.Size = new System.Drawing.Size(152, 22);
      this.openMenuItem.Text = "Öppna";
      this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
      // 
      // saveAsMenuItem
      // 
      this.saveAsMenuItem.Name = "saveAsMenuItem";
      this.saveAsMenuItem.Size = new System.Drawing.Size(152, 22);
      this.saveAsMenuItem.Text = "Spara som";
      this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
      // 
      // saveMenuItem
      // 
      this.saveMenuItem.Name = "saveMenuItem";
      this.saveMenuItem.Size = new System.Drawing.Size(152, 22);
      this.saveMenuItem.Text = "Spara";
      this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
      // 
      // exitMenuItem
      // 
      this.exitMenuItem.Name = "exitMenuItem";
      this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitMenuItem.Text = "Avsluta";
      this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
      // 
      // redigeraToolStripMenuItem
      // 
      this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem});
      this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
      this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
      this.redigeraToolStripMenuItem.Text = "Redigera";
      // 
      // cutMenuItem
      // 
      this.cutMenuItem.Name = "cutMenuItem";
      this.cutMenuItem.Size = new System.Drawing.Size(125, 22);
      this.cutMenuItem.Text = "Klipp ut";
      this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
      // 
      // copyMenuItem
      // 
      this.copyMenuItem.Name = "copyMenuItem";
      this.copyMenuItem.Size = new System.Drawing.Size(125, 22);
      this.copyMenuItem.Text = "Kopiera";
      this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
      // 
      // pasteMenuItem
      // 
      this.pasteMenuItem.Name = "pasteMenuItem";
      this.pasteMenuItem.Size = new System.Drawing.Size(125, 22);
      this.pasteMenuItem.Text = "Klistra in";
      this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveAsButton,
            this.saveButton,
            this.cutButton,
            this.copyButton,
            this.pasteButton});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(292, 25);
      this.toolStrip1.Stretch = true;
      this.toolStrip1.TabIndex = 1;
      // 
      // newButton
      // 
      this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
      this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newButton.Name = "newButton";
      this.newButton.Size = new System.Drawing.Size(23, 22);
      this.newButton.Text = "Ny";
      this.newButton.Click += new System.EventHandler(this.newMenuItem_Click);
      // 
      // openButton
      // 
      this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
      this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openButton.Name = "openButton";
      this.openButton.Size = new System.Drawing.Size(23, 22);
      this.openButton.Text = "Öppna";
      this.openButton.Click += new System.EventHandler(this.openMenuItem_Click);
      // 
      // saveAsButton
      // 
      this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
      this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveAsButton.Name = "saveAsButton";
      this.saveAsButton.Size = new System.Drawing.Size(23, 22);
      this.saveAsButton.Text = "Spara som";
      this.saveAsButton.Click += new System.EventHandler(this.saveAsMenuItem_Click);
      // 
      // saveButton
      // 
      this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
      this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(23, 22);
      this.saveButton.Text = "Spara";
      this.saveButton.Click += new System.EventHandler(this.saveMenuItem_Click);
      // 
      // cutButton
      // 
      this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
      this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutButton.Name = "cutButton";
      this.cutButton.Size = new System.Drawing.Size(23, 22);
      this.cutButton.Text = "Klipp ut";
      this.cutButton.Click += new System.EventHandler(this.cutMenuItem_Click);
      // 
      // copyButton
      // 
      this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
      this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyButton.Name = "copyButton";
      this.copyButton.Size = new System.Drawing.Size(23, 22);
      this.copyButton.Text = "Kopiera";
      this.copyButton.Click += new System.EventHandler(this.copyMenuItem_Click);
      // 
      // pasteButton
      // 
      this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
      this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteButton.Name = "pasteButton";
      this.pasteButton.Size = new System.Drawing.Size(23, 22);
      this.pasteButton.Text = "Klistra in";
      this.pasteButton.Click += new System.EventHandler(this.pasteMenuItem_Click);
      // 
      // openDialog
      // 
      this.openDialog.FileName = "openFileDialog1";
      // 
      // TextEdit2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.toolStripContainer1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "TextEdit2";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextEdit2_FormClosed);
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
    private System.Windows.Forms.ToolStripButton openButton;
    private System.Windows.Forms.ToolStripButton newButton;
    private System.Windows.Forms.ToolStripButton saveButton;
    private System.Windows.Forms.ToolStripButton saveAsButton;
    private System.Windows.Forms.ToolStripButton cutButton;
    private System.Windows.Forms.ToolStripButton copyButton;
    private System.Windows.Forms.ToolStripButton pasteButton;
    private System.Windows.Forms.RichTextBox area;
    private System.Windows.Forms.OpenFileDialog openDialog;
    private System.Windows.Forms.SaveFileDialog saveAsDialog;
  }
}

