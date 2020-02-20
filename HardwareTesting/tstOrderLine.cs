using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareClasses;

namespace HardwareTesting
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void Test_isInstanceOk()
        {
            clsOrderLine order = new clsOrderLine();
            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void Test_findMethodExists()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderLineId = 2;

            found = AnOrderLine.find(OrderLineId);

            if (AnOrderLine.OrderLineId != OrderLineId)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_OrderLineIdIsFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderLineId = 2;

            found = AnOrderLine.find(2);

            if (AnOrderLine.OrderLineId != OrderLineId)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_OrderIdIsFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrderLine.find(2);

            if (AnOrderLine.OrderId != OrderId)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_ProductIdIsFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean found = false;

            Boolean ok = true;

            Int32 ProductId = 1;

            found = AnOrderLine.find(2);

            if (AnOrderLine.ProductId != ProductId)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }
        [TestMethod]
        public void Test_QuantityIsFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean found = false;

            Boolean ok = true;

            Int32 quantity = 10;

            found = AnOrderLine.find(2);

            if (AnOrderLine.Quantity != quantity)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_OrderIdFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrderLine.find(2);

            if (AnOrderLine.OrderId != OrderId)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_ProductIdFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            int TestData = 1;

            AnOrderLine.ProductId = 1;

            Assert.AreEqual(AnOrderLine.ProductId, TestData);
        }

        [TestMethod]
        public void Test_QuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            int TestData = 3;

            AnOrderLine.Quantity = 3;

            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }
    }
}
