using AdressbokEntityFrameworkMaj2018.DAL;
using AdressbokEntityFrameworkMaj2018.DataContext;
using AdressbokEntityFrameworkMaj2018.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressbokEntityFrameworkMaj2018
{
    public partial class Form1 : Form
    {
        private DataAccess dataAccess;

        public Form1()
        {
            dataAccess = new DataAccess();

            InitializeComponent();
            FillContactComboBox();
            GetAllAddresses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //General
        private void AllContactsBtn_Click(object sender, EventArgs e)
        {
            GetAllAddresses();
        }

        private void GetAllAddresses()
        {
            var contacts = dataAccess.GetAddresses();

            dataGridView1.DataSource = contacts;
        }

        private void FillContactComboBox()
        {
            TypeContactComboBox.Items.Add("Private");
            TypeContactComboBox.Items.Add("Work");
            TypeContactComboBox.Items.Add("Other");
        }

        private void ClearTextBoxes()
        {
            TypeContactComboBox.ResetText();
            NameInput.Clear();
            StreetNameInput.Clear();
            ZipCodeInput.Clear();
            PostalAreaInput.Clear();
            PhoneNumberInput.Clear();
            EmailInput.Clear();
        }

        private int GetContactId()
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            string contactIdStringValue = dataGridView1["ContactID", currentRow].Value.ToString();

            int contactID = Int32.Parse(contactIdStringValue);

            return contactID;
        }

        private int GetContactTypeId(string ContactType)
        {
            if (ContactType == "Private")
            {
                return 1;
            }
            else if (ContactType == "Work")
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        //Save
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveNewContact();
        }

        private void SaveNewContact()
        {
            var newContact = new ContactModel();

            newContact.Name = NameInput.Text;
            newContact.StreetName = StreetNameInput.Text;
            newContact.ZipCode = ZipCodeInput.Text;
            newContact.PostalArea = PostalAreaInput.Text;
            newContact.PhoneNumber = PhoneNumberInput.Text;
            newContact.Email = EmailInput.Text;
            newContact.ContactType = GetContactTypeId(TypeContactComboBox.Text);
            
            dataAccess.SaveNewContact(newContact);

            MessageBox.Show("Contact has successfully been created");

            GetAllAddresses();
            ClearTextBoxes();
        }

        //Delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        private void DeleteContact()
        {
            int contactId = GetContactId();

            using (var db = new Model1())
            {
                ContactInformation dbModel = (from contact in db.ContactInformation
                                              where contact.ContactID == contactId
                                              select contact).SingleOrDefault();

                db.ContactInformation.Remove(dbModel);

                db.SaveChanges();
            }

           

            MessageBox.Show("Contact has successfully been deleted");
            GetAllAddresses();
        }

        //Update
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateContact();
        }

        private void UpdateContact()
        {
            var contact = new ContactModel();

            contact.ContactID = GetContactId();
            contact.Name = NameInput.Text;
            contact.StreetName = StreetNameInput.Text;
            contact.ZipCode = ZipCodeInput.Text;
            contact.PostalArea = PostalAreaInput.Text;
            contact.PhoneNumber = PhoneNumberInput.Text;
            contact.Email = EmailInput.Text;
            contact.ContactType = GetContactTypeId(TypeContactComboBox.Text);

            dataAccess.UpdateContact(contact);

            MessageBox.Show("Contact has successfully been created");
            GetAllAddresses();
            ClearTextBoxes();
        }

        //Search
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForContact();
        }

        private void SearchForContact()
        {
            var searchInput = SearchInput.Text;
            var contactTypeInput = GetContactTypeFromRadioButtons();

            dataGridView1.DataSource = dataAccess.SearchForContact(searchInput, contactTypeInput);
        }

        private int GetContactTypeFromRadioButtons()
        {
            if (privateRadioButton.Checked)
            {
                return 1;
            }
            else if (WorkRadioButton.Checked)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        //Double click
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FillAllInputFieldsWithChosenContact();
        }

        private void FillAllInputFieldsWithChosenContact()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                NameInput.Text = row.Cells[1].Value.ToString();
                StreetNameInput.Text = row.Cells[2].Value.ToString();
                ZipCodeInput.Text = row.Cells[3].Value.ToString();
                PostalAreaInput.Text = row.Cells[4].Value.ToString();
                PhoneNumberInput.Text = row.Cells[5].Value.ToString();
                EmailInput.Text = row.Cells[6].Value.ToString();
                TypeContactComboBox.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
