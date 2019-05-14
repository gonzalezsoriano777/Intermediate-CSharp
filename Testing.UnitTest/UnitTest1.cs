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

        // testing methods for different situations or processes

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            // *
            Assert.IsTrue(order.isShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }


    }

    // Used if order was not successfully shipped and need to ship prop. of order

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }

    }
}
