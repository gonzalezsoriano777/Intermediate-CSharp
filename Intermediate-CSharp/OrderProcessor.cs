using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class OrderProcessor
    {
        // used to make OrderProcessor isolated for unit testing, by introducing an interface, making it also not dependent on concrete classes
        private readonly IShippingCalculator _shippingCalculator;
        

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        

        public void Process(Order order)
        {
            if (order.isShipped)

                // used for defensive programming 
                throw new InvalidOperationException("Order is already processing");

            // if order is ready to be shipped then it will show the cost and shipping date
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };

                
            
        }
    }
}
