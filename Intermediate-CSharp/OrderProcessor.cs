using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;    

        public OrderProcessor(ShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.isShipping)
            {
                throw InvalidOperationException("Order is already processing");
            }
        }
    }
}
