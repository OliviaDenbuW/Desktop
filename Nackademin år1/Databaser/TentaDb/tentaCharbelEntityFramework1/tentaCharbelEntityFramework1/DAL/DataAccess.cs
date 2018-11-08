using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tentaCharbelEntityFramework1.Models;
using System.ComponentModel;
using tentaCharbelEntityFramework1.DataContext;

namespace tentaCharbelEntityFramework1.DAL
{
    class DataAccess
    {
        public BindingList<CustomerModel> GetCustomers()
        {
            BindingList<CustomerModel> customers;

            using (var dataContext = new Model1())
            {
                var query = from customer in dataContext.Customers
                            where (customer.City.Contains("Madrid"))
                            select new CustomerModel
                            {
                                CustomerID = customer.CustomerID,
                                CompanyName = customer.CompanyName,
                                ContactName = customer.ContactName,
                                ContactTitle = customer.ContactTitle,
                                Address = customer.Address,
                                City = customer.City,
                                Region = customer.Region,
                                PostalCode = customer.PostalCode,
                                Country = customer.Country,
                                Phone = customer.Phone,
                                Fax = customer.Fax
                            };

                customers = new BindingList<CustomerModel>(query.ToList());
            }

            return customers;
        }
    }
}
