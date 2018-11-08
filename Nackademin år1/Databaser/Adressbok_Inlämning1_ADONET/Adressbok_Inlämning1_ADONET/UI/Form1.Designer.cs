namespace Adressbok_Inlämning1_ADONET
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PostalAreaInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.StreetNameInput = new System.Windows.Forms.TextBox();
            this.ZipCodeInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.PhoneNumberInput = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.StreetNameLbl = new System.Windows.Forms.Label();
            this.ZipCodeLbl = new System.Windows.Forms.Label();
            this.PostalAreaLbl = new System.Windows.Forms.Label();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.TypeOfContactLbl = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AllContactsBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TypeContactComboBox = new System.Windows.Forms.ComboBox();
            this.privateRadioButton = new System.Windows.Forms.RadioButton();
            this.WorkRadioButton = new System.Windows.Forms.RadioButton();
            this.OtherRadioButton = new System.Windows.Forms.RadioButton();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 650);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick_1);
            // 
            // PostalAreaInput
            // 
            this.PostalAreaInput.Location = new System.Drawing.Point(1528, 371);
            this.PostalAreaInput.Name = "PostalAreaInput";
            this.PostalAreaInput.Size = new System.Drawing.Size(560, 31);
            this.PostalAreaInput.TabIndex = 1;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(1528, 146);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(560, 31);
            this.NameInput.TabIndex = 2;
            // 
            // StreetNameInput
            // 
            this.StreetNameInput.Location = new System.Drawing.Point(1528, 213);
            this.StreetNameInput.Name = "StreetNameInput";
            this.StreetNameInput.Size = new System.Drawing.Size(560, 31);
            this.StreetNameInput.TabIndex = 3;
            // 
            // ZipCodeInput
            // 
            this.ZipCodeInput.Location = new System.Drawing.Point(1528, 293);
            this.ZipCodeInput.Name = "ZipCodeInput";
            this.ZipCodeInput.Size = new System.Drawing.Size(560, 31);
            this.ZipCodeInput.TabIndex = 4;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(1528, 531);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(560, 31);
            this.EmailInput.TabIndex = 7;
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.Location = new System.Drawing.Point(1528, 444);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(560, 31);
            this.PhoneNumberInput.TabIndex = 8;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(1350, 151);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(68, 25);
            this.NameLbl.TabIndex = 9;
            this.NameLbl.Text = "Name";
            // 
            // StreetNameLbl
            // 
            this.StreetNameLbl.AutoSize = true;
            this.StreetNameLbl.Location = new System.Drawing.Point(1350, 218);
            this.StreetNameLbl.Name = "StreetNameLbl";
            this.StreetNameLbl.Size = new System.Drawing.Size(128, 25);
            this.StreetNameLbl.TabIndex = 10;
            this.StreetNameLbl.Text = "Street name";
            // 
            // ZipCodeLbl
            // 
            this.ZipCodeLbl.AutoSize = true;
            this.ZipCodeLbl.Location = new System.Drawing.Point(1350, 292);
            this.ZipCodeLbl.Name = "ZipCodeLbl";
            this.ZipCodeLbl.Size = new System.Drawing.Size(95, 25);
            this.ZipCodeLbl.TabIndex = 10;
            this.ZipCodeLbl.Text = "Zip code";
            // 
            // PostalAreaLbl
            // 
            this.PostalAreaLbl.AutoSize = true;
            this.PostalAreaLbl.Location = new System.Drawing.Point(1350, 370);
            this.PostalAreaLbl.Name = "PostalAreaLbl";
            this.PostalAreaLbl.Size = new System.Drawing.Size(121, 25);
            this.PostalAreaLbl.TabIndex = 10;
            this.PostalAreaLbl.Text = "Postal area";
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.AutoSize = true;
            this.PhoneNumberLbl.Location = new System.Drawing.Point(1350, 446);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(152, 25);
            this.PhoneNumberLbl.TabIndex = 10;
            this.PhoneNumberLbl.Text = "Phone number";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(1350, 530);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(72, 25);
            this.EmailLbl.TabIndex = 10;
            this.EmailLbl.Text = "E-mail";
            // 
            // TypeOfContactLbl
            // 
            this.TypeOfContactLbl.AutoSize = true;
            this.TypeOfContactLbl.Location = new System.Drawing.Point(1350, 609);
            this.TypeOfContactLbl.Name = "TypeOfContactLbl";
            this.TypeOfContactLbl.Size = new System.Drawing.Size(160, 25);
            this.TypeOfContactLbl.TabIndex = 10;
            this.TypeOfContactLbl.Text = "Type of contact";
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(32, 91);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(560, 31);
            this.SearchInput.TabIndex = 12;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(656, 92);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(202, 75);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AllContactsBtn
            // 
            this.AllContactsBtn.Location = new System.Drawing.Point(916, 92);
            this.AllContactsBtn.Name = "AllContactsBtn";
            this.AllContactsBtn.Size = new System.Drawing.Size(202, 75);
            this.AllContactsBtn.TabIndex = 14;
            this.AllContactsBtn.Text = "View all contacts";
            this.AllContactsBtn.UseVisualStyleBackColor = true;
            this.AllContactsBtn.Click += new System.EventHandler(this.AllContactsBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(32, 943);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(202, 75);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(1787, 673);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(202, 75);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TypeContactComboBox
            // 
            this.TypeContactComboBox.FormattingEnabled = true;
            this.TypeContactComboBox.Location = new System.Drawing.Point(1528, 601);
            this.TypeContactComboBox.Name = "TypeContactComboBox";
            this.TypeContactComboBox.Size = new System.Drawing.Size(560, 33);
            this.TypeContactComboBox.TabIndex = 17;
            // 
            // privateRadioButton
            // 
            this.privateRadioButton.AutoSize = true;
            this.privateRadioButton.Location = new System.Drawing.Point(32, 138);
            this.privateRadioButton.Name = "privateRadioButton";
            this.privateRadioButton.Size = new System.Drawing.Size(110, 29);
            this.privateRadioButton.TabIndex = 18;
            this.privateRadioButton.TabStop = true;
            this.privateRadioButton.Text = "Private";
            this.privateRadioButton.UseVisualStyleBackColor = true;
            // 
            // WorkRadioButton
            // 
            this.WorkRadioButton.AutoSize = true;
            this.WorkRadioButton.Location = new System.Drawing.Point(180, 138);
            this.WorkRadioButton.Name = "WorkRadioButton";
            this.WorkRadioButton.Size = new System.Drawing.Size(93, 29);
            this.WorkRadioButton.TabIndex = 19;
            this.WorkRadioButton.TabStop = true;
            this.WorkRadioButton.Text = "Work";
            this.WorkRadioButton.UseVisualStyleBackColor = true;
            // 
            // OtherRadioButton
            // 
            this.OtherRadioButton.AutoSize = true;
            this.OtherRadioButton.Location = new System.Drawing.Point(315, 138);
            this.OtherRadioButton.Name = "OtherRadioButton";
            this.OtherRadioButton.Size = new System.Drawing.Size(96, 29);
            this.OtherRadioButton.TabIndex = 20;
            this.OtherRadioButton.TabStop = true;
            this.OtherRadioButton.Text = "Other";
            this.OtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(1528, 673);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(202, 75);
            this.UpdateBtn.TabIndex = 21;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2088, 1030);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.OtherRadioButton);
            this.Controls.Add(this.WorkRadioButton);
            this.Controls.Add(this.privateRadioButton);
            this.Controls.Add(this.TypeContactComboBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AllContactsBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.TypeOfContactLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.PhoneNumberLbl);
            this.Controls.Add(this.PostalAreaLbl);
            this.Controls.Add(this.ZipCodeLbl);
            this.Controls.Add(this.StreetNameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.ZipCodeInput);
            this.Controls.Add(this.StreetNameInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.PostalAreaInput);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PostalAreaInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox StreetNameInput;
        private System.Windows.Forms.TextBox ZipCodeInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox PhoneNumberInput;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label StreetNameLbl;
        private System.Windows.Forms.Label ZipCodeLbl;
        private System.Windows.Forms.Label PostalAreaLbl;
        private System.Windows.Forms.Label PhoneNumberLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label TypeOfContactLbl;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AllContactsBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox TypeContactComboBox;
        private System.Windows.Forms.RadioButton privateRadioButton;
        private System.Windows.Forms.RadioButton WorkRadioButton;
        private System.Windows.Forms.RadioButton OtherRadioButton;
        private System.Windows.Forms.Button UpdateBtn;
    }
}

