using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using omtentaUppg4EnitityFramework.Models;
using omtentaUppg4EnitityFramework.DataContext;

namespace omtentaUppg4EnitityFramework.DAL
{
    class DataAccess
    {
        public BindingList<ProductModel> GetProducts()
        {
            BindingList<ProductModel> products;

            using (var dataContext = new Model1())
            {
                var query = from product in dataContext.Products
                            join category in dataContext.Categories on product.CategoryID equals category.CategoryID
                            where (category.CategoryName.Contains("Beverages"))

                select new ProductModel
                            {
                                UnitPrice = product.UnitPrice                                
                            };

                products = new BindingList<ProductModel>(query.ToList());
            }

            return products;
        }
    }
}
