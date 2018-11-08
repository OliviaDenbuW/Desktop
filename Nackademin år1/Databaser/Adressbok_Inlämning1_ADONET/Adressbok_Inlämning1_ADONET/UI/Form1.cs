using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adressbok_Inlämning1_ADONET.DAL;

namespace Adressbok_Inlämning1_ADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillContactComboBox();
            GetAllContacts();
        }

        //General
        private void AllContactsBtn_Click(object sender, EventArgs e)
        {
            GetAllContacts();
        }

        private void GetAllContacts()
        {
            var commandText = GetCommandTextGetAllContacts();

            var dataAccess = new DataAccess();
            var contacts = dataAccess.ExcecuteSelectCommand(commandText, CommandType.Text, null);

            dataGridView1.DataSource = contacts.Tables[0];
        }

        private string GetCommandTextGetAllContacts()
        {
            var commandText = "select ContactID, Name, StreetName, ZipCode, PostalArea, PhoneNumber, Email, ct.RelationType" +
                                 " from ContactType ct" +
                                 " inner join ContactInformation" +
                                 " on ContactInformation.TypeOfContactID = ct.TypeID";

            return commandText;
        }

        private int GetContactId()
        {
            var currentRow = dataGridView1.CurrentCell.RowIndex;
            var contactIdStringValue = dataGridView1["ContactID", currentRow].Value.ToString();

            var contactID = Int32.Parse(contactIdStringValue);

            return contactID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FillContactComboBox()
        {
            TypeContactComboBox.Items.Add("Private");
            TypeContactComboBox.Items.Add("Work");
            TypeContactComboBox.Items.Add("Other");
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

        //Save
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveNewContact();
        }

        private void SaveNewContact()
        {
            var dataAccess = new DataAccess();
            var commandText = GetCommandTextSave();

            var person = dataAccess.ExcecuteSelectCommand(commandText, CommandType.Text, null);

            dataGridView1.DataSource = person.Tables[0];
            GetAllContacts();
            ClearTextBoxes();
        }

        private string GetCommandTextSave()
        {
            var name = NameInput.Text;
            var streetAddress = StreetNameInput.Text;
            var zipCode = ZipCodeInput.Text;
            var postalArea = PostalAreaInput.Text;
            var phoneNumber = PhoneNumberInput.Text;
            var email = EmailInput.Text;
            var typeOfContact = GetContactTypeId(TypeContactComboBox.Text)/*TypeContactComboBox.SelectedItem*/;

            var commandText = $" insert into ContactInformation(Name, StreetName, ZipCode, PostalArea, PhoneNumber, Email, TypeOfContactID) " +
                          $" values('{name}', '{streetAddress}', '{zipCode}', '{postalArea}', '{phoneNumber}', '{email}', '{typeOfContact}')";

            return commandText;
        }

        //Delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        private void DeleteContact()
        {
            DataAccess dataAccess = new DataAccess();

            int contactId = GetContactId();

            string commandText = GetCommandTextDelete();

            SqlParameter[] parameters = GetDeleteParameter(contactId);

            bool CheckAdd = dataAccess.MyExecuteNonQuery(commandText, CommandType.Text, parameters);

            GetAllContacts();
            ClearTextBoxes();

            if (CheckAdd)
            {
                MessageBox.Show("Address has successfully been deleted");
            }
            else
            {
                MessageBox.Show("Address could not be deleted");
            }
        }

        private string GetCommandTextDelete()
        {
            string commandText = "Delete from ContactInformation where ContactID = @Id";

            return commandText;
        }

        private SqlParameter[] GetDeleteParameter(int contactId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", contactId)
            };

            return parameters;
        }

        //Search
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForContact();
        }

        private void SearchForContact()
        {
            var dataAccess = new DataAccess();

            var contactType = GetContactTypeFromRadioButtons();

            var commandText = GetCommandTextSearch(contactType);

            var parameters = GetSearchInput();

            var searchedContacts = dataAccess.ExcecuteSelectCommand(commandText, CommandType.Text, parameters);

            dataGridView1.DataSource = searchedContacts.Tables[0];
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

        private string GetCommandTextSearch(int contactType)
        {
            var commandText = "select ContactID, Name, StreetName, ZipCode, PostalArea, PhoneNumber, Email, ct.RelationType" +
                                 " from ContactType ct" +
                                 " inner join ContactInformation" +
                                 " on ContactInformation.TypeOfContactID = ct.TypeID" +
                                 " where(Name like @search or PostalArea like @search) and TypeID = " + contactType + ";";

            return commandText;
        }

        private SqlParameter[] GetSearchInput()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@search", "%" + SearchInput.Text + "%")
            };

            return parameters;
        }

        //Update
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateContact();
        }

        private void UpdateContact()
        {
            var dataAccess = new DataAccess();

            var contactId = GetContactId();
            var commandText = GetCommandTextUpdate(contactId);
            var parameters = GetUpdateParameters();            

            var updateBtnIsClicked = dataAccess.MyExecuteNonQuery(commandText, CommandType.Text, parameters);

            GetAllContacts();
            ClearTextBoxes();

            if (updateBtnIsClicked)
            {
                MessageBox.Show("Address has been successfully updated");
            }
            else
            {
                MessageBox.Show("Address could not be updated");
            }
        }

        private string GetCommandTextUpdate(int contactId)
        {
            string commandText = "UPDATE ContactInformation " +
                                 "SET Name = @Name, StreetName = @StreetName, ZipCode = @ZipCode, PostalArea = @PostalArea, PhoneNumber = @PhoneNumber, Email = @Email, TypeOfContactID = @TypeOfContactID " +
                                 "WHERE ContactID =" + contactId + ";";

            return commandText;
        }

        private SqlParameter[] GetUpdateParameters()
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Name",NameInput.Text),
                new SqlParameter("@StreetName",StreetNameInput.Text),
                new SqlParameter("@ZipCode",ZipCodeInput.Text),
                new SqlParameter("@PostalArea",PostalAreaInput.Text),
                new SqlParameter("@PhoneNumber", PhoneNumberInput.Text),
                new SqlParameter("@Email", EmailInput.Text),
                new SqlParameter("@TypeOfContactID", GetContactTypeId(TypeContactComboBox.Text))
            };

            return parameters;
        }
        
        //Double click
        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
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