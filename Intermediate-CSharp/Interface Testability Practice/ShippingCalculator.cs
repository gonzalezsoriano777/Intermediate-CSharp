using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    // provides the capability that the class should provide
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }


    public class ShippingCalculator : IShippingCalculator
    {
        // this will include the price if there is cents included
        public float CalculateShipping(Order order)
        {
            // Once totalPrice for product is shown, shipping price will be declared if price is below $30
            if (order.TotalPrice > 30f)

                // if price below 30 then 10% of shipping will be added to totalPrice
                return order.TotalPrice * 0.1f;

                // but if price is above 30 then it's free shipping
                return 0;
        }
    }
}
