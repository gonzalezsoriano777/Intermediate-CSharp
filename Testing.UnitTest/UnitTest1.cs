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
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor();
        }


    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            throw new NotImplementedException();
        }

    }
}
