using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tentaUppg7.DataContext;
using tentaUppg7.Models;
using System.ComponentModel;

namespace tentaUppg7.DAL
{
    class DataAccess
    {
        public BindingList<ProductModel> ProductSearch()
        {
            BindingList<ProductModel> searchedProducts;

            var query = from products in DataContext.Products
            select {
                productName = products.productName,
                
            }
        }
    }
}
