using AdressbokEntityFrameworkMaj2018.DataContext;
using AdressbokEntityFrameworkMaj2018.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdressbokEntityFrameworkMaj2018.DAL
{
    class DataAccess
    {
        public BindingList<ContactModel> GetAddresses()
        {
            BindingList<ContactModel> contacts;

            using (var db = new Model1())
            {
                var query = from contact in db.ContactInformation
                            join contactType in db.ContactType on contact.TypeOfContactID equals contactType.TypeID
                            orderby contact.Name
                            select new ContactModel
                            {
                                ContactID = contact.ContactID,
                                Name = contact.Name,
                                StreetName = contact.StreetName,
                                ZipCode = contact.ZipCode.ToString(),
                                PostalArea = contact.PostalArea,
                                PhoneNumber = contact.PhoneNumber.ToString(),
                                Email = contact.Email,
                                ContactType = contactType.TypeID
                            };

                contacts = new BindingList<ContactModel>(query.ToList());
            }

            return contacts;
        }

        public void SaveNewContact(ContactModel newContact)
        {
            using (var db = new Model1())
            {
                var contact = new ContactInformation();

                contact.Name = newContact.Name;
                contact.StreetName = newContact.StreetName;
                contact.ZipCode = Int32.Parse(newContact.ZipCode);
                contact.PostalArea = newContact.PostalArea;
                contact.PhoneNumber = Int32.Parse(newContact.PhoneNumber);
                contact.Email = newContact.Email;
                contact.TypeOfContactID = newContact.ContactType;

                db.ContactInformation.Add(contact);
                db.SaveChanges();
            }
        }

        public void UpdateContact(ContactModel newContact)
        {
            using (var db = new Model1())
            {
                ContactInformation contactDb = (from contact in db.ContactInformation
                                                where contact.ContactID == newContact.ContactID
                                                select contact).SingleOrDefault();

                contactDb.Name = newContact.Name;
                contactDb.StreetName = newContact.StreetName;
                contactDb.ZipCode = Int32.Parse(newContact.ZipCode);
                contactDb.PostalArea = newContact.PostalArea;
                contactDb.PhoneNumber = Int32.Parse(newContact.PhoneNumber);
                contactDb.Email = newContact.Email;
                contactDb.TypeOfContactID = newContact.ContactType;

                db.SaveChanges();
            }
        }

        public BindingList<ContactModel> SearchForContact(string searchInput, int inputContactType)
        {
            BindingList<ContactModel> searchResult;

            using (var db = new Model1())
            {
                var query = from contact in db.ContactInformation
                            where (contact.Name.Contains(searchInput) ||
                            contact.PostalArea.Contains(searchInput)) &
                            contact.TypeOfContactID == inputContactType

                            select new ContactModel()
                            {
                                ContactID = contact.ContactID,
                                Name = contact.Name,
                                StreetName = contact.StreetName,
                                ZipCode = contact.ZipCode.ToString(),
                                PostalArea = contact.PostalArea,                                
                                PhoneNumber = contact.PhoneNumber.ToString(),
                                Email = contact.Email,
                                ContactType = contact.TypeOfContactID
                            };

                searchResult = new BindingList<ContactModel>(query.ToList());
            }

            return searchResult;
        }

        public ContactInformation GetContactData(int contactId)
        {
            using (var db = new Model1())
            {
                var currentContact = db.ContactInformation.SingleOrDefault(contact => contact.ContactID == contactId);

                return currentContact;
            }
        }

        public string GetContactType(int typeId)
        {
            if (typeId == 1)
            {
                return "Private";
            }
            else if (typeId == 2)
            {
                return "Work";
            }
            else
            {
                return "Other";
            }
        }
    }
}
