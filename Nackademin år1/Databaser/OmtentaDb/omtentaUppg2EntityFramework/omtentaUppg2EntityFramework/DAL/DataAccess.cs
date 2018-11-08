using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using omtentaUppg2EntityFramework.Models;
using System.ComponentModel;
using omtentaUppg2EntityFramework.DataContext;

namespace omtentaUppg2EntityFramework.DAL
{
    class DataAccess
    {
        public BindingList<OrderModel> GetOrders()
        {
            BindingList<OrderModel> searchedOrders;

            using (var dataContext = new Model1())
            {
                var query = from order in dataContext.Orders
                            where order.Customers.CustomerID.Contains("ALFKI")
                            select new OrderModel
                            {
                                CustomerID = order.CustomerID,
                                OrderID = order.OrderID
                            };

                searchedOrders = new BindingList<OrderModel>(query.Distinct().ToList());
            }

            return searchedOrders;
        }
    }
}
