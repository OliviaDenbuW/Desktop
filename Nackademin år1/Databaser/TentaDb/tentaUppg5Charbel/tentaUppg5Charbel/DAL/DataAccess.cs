using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using tentaUppg5Charbel.Models;
using tentaUppg5Charbel.DataContext;


namespace tentaUppg5Charbel.DAL
{
    class DataAccess
    {
        public BindingList<SuppliersModel> SuppliersWithMoreThanThree()
        {
            BindingList<SuppliersModel> searchedSuppliers;

            using(var dataContext = new Model1())
            {
                var query = from supplier in dataContext.Suppliers
                            join product in dataContext.Products on supplier.SupplierID equals product.SupplierID
                            where supplier.Products.Count() > 3
                            select new SuppliersModel
                            {
                                CompanyName = supplier.CompanyName,
                                NumberOfProducts = supplier.Products.Count()
                            };

                searchedSuppliers = new BindingList<SuppliersModel>(query.Distinct().ToList());
            }

            return searchedSuppliers;
        }
    }
}
