using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestabilityMosh
{
    class ShippingCalculator
    {
        OrderProcessor orderProcessor = new OrderProcessor();
        Order order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        OrderProcessor.Process(order);
    }
}
