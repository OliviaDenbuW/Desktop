namespace HannaDemoLetionsTidAdoNet.UI
{
    partial class Northwind2
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
            this.components = new System.ComponentModel.Container();
            this.Northwind2Datagridview = new System.Windows.Forms.DataGridView();
            this.orderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Northwind2Datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Northwind2Datagridview
            // 
            this.Northwind2Datagridview.AllowUserToAddRows = false;
            this.Northwind2Datagridview.AllowUserToDeleteRows = false;
            this.Northwind2Datagridview.AutoGenerateColumns = false;
            this.Northwind2Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Northwind2Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.shipNameDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn});
            this.Northwind2Datagridview.DataSource = this.orderModelBindingSource1;
            this.Northwind2Datagridview.Location = new System.Drawing.Point(69, 91);
            this.Northwind2Datagridview.Name = "Northwind2Datagridview";
            this.Northwind2Datagridview.RowTemplate.Height = 24;
            this.Northwind2Datagridview.Size = new System.Drawing.Size(653, 195);
            this.Northwind2Datagridview.TabIndex = 0;
            // 
            // orderModelBindingSource
            // 
            this.orderModelBindingSource.DataSource = typeof(HannaDemoLetionsTidAdoNet.Models.OrderModel);
            // 
            // orderModelBindingSource1
            // 
            this.orderModelBindingSource1.DataSource = typeof(HannaDemoLetionsTidAdoNet.Models.OrderModel);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // shipNameDataGridViewTextBoxColumn
            // 
            this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
            this.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName";
            this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
            // 
            // shipCityDataGridViewTextBoxColumn
            // 
            this.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
            // 
            // Northwind2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 333);
            this.Controls.Add(this.Northwind2Datagridview);
            this.Name = "Northwind2";
            this.Text = "Northwind2";
            ((System.ComponentModel.ISupportInitialize)(this.Northwind2Datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Northwind2Datagridview;
        private System.Windows.Forms.BindingSource orderModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderModelBindingSource1;
    }
}