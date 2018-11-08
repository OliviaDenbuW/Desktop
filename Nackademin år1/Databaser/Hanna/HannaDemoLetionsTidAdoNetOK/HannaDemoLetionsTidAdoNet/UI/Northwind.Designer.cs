namespace HannaDemoLetionsTidAdoNet
{
    partial class Northwind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NortwindDataGridView = new System.Windows.Forms.DataGridView();
            this.ResultLable = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NortwindDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NortwindDataGridView
            // 
            this.NortwindDataGridView.AllowUserToAddRows = false;
            this.NortwindDataGridView.AllowUserToDeleteRows = false;
            this.NortwindDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NortwindDataGridView.Location = new System.Drawing.Point(48, 288);
            this.NortwindDataGridView.Name = "NortwindDataGridView";
            this.NortwindDataGridView.RowTemplate.Height = 24;
            this.NortwindDataGridView.Size = new System.Drawing.Size(922, 204);
            this.NortwindDataGridView.TabIndex = 0;
            this.NortwindDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.NortwindDataGridView_CellEndEdit);
            // 
            // ResultLable
            // 
            this.ResultLable.AutoSize = true;
            this.ResultLable.Location = new System.Drawing.Point(83, 60);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(0, 17);
            this.ResultLable.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(844, 50);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(185, 82);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete Row";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Northwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 526);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ResultLable);
            this.Controls.Add(this.NortwindDataGridView);
            this.Name = "Northwind";
            this.Text = "Northwind";
            ((System.ComponentModel.ISupportInitialize)(this.NortwindDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NortwindDataGridView;
        private System.Windows.Forms.Label ResultLable;
        private System.Windows.Forms.Button DeleteButton;
    }
}

