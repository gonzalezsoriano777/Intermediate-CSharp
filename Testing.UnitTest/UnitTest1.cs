using System;
using Intermediate_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.UnitTest
{
    [TestClass]
    public class OrderProcessorTest
    {

        // METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.isShipped);
        }


    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }

    }
}
