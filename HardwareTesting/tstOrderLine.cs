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
        [TestMethod]
        public void Test_orderLineIdBlank()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderLineId = "";

            error = orderline.Validate(orderLineId, "1", "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderLineIdMinLessOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderLineId = "";

            error = orderline.Validate(orderLineId, "1", "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderLineIdMin()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderLineId = "a";

            error = orderline.Validate(orderLineId, "1", "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderLineIdMinPlusOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderLineId = "aa";

            error = orderline.Validate(orderLineId, "1", "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderLineIdMaxLessOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderLineId = "aaaaa";

            error = orderline.Validate(orderLineId, "1", "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderLineIdMax()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderLineId = "aaaaaa";

            error = orderline.Validate(orderLineId, "1", "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderLineIdMid()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderLineId = "aaa";

            error = orderline.Validate(orderLineId, "1", "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderLineIdExtremeMax()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderLineId = "";
            orderLineId = orderLineId.PadRight(500, 'a');

            error = orderline.Validate(orderLineId, "1", "1", "1");

            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void Test_orderIdBlank()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderId = "";

            error = orderline.Validate("1", orderId, "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMinLessOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderId = "";

            error = orderline.Validate("1", orderId, "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMin()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderId = "a";

            error = orderline.Validate("1", orderId, "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMinPlusOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderId = "aa";

            error = orderline.Validate("1", orderId, "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMaxLessOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderId = "aaaaa";

            error = orderline.Validate("1", orderId, "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMax()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderId = "aaaaaa";

            error = orderline.Validate("1", orderId, "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMid()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderId = "aaa";

            error = orderline.Validate("1", orderId, "1", "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdExtremeMax()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string orderId = "";
            orderId = orderId.PadRight(500, 'a');

            error = orderline.Validate("1", orderId, "1", "1");

            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void Test_productIdBlank()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string productId = "";

            error = orderline.Validate("1", "1", productId, "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_productIdMinLessOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string productId = "";

            error = orderline.Validate("1", "1", productId, "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_productIdMin()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string productId = "a";

            error = orderline.Validate("1", "1", productId, "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_productIdMinPlusOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string productId = "aa";

            error = orderline.Validate("1", "1", productId, "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_productIdMaxLessOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string productId = "aaaaa";

            error = orderline.Validate("1", "1", productId, "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_productIdMax()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string productId = "aaaaaa";

            error = orderline.Validate("1", "1", productId, "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_productIdMid()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string productId = "aaa";

            error = orderline.Validate("1", "1", productId, "1");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_productIdExtremeMax()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string productId = "";
            productId = productId.PadRight(500, 'a');

            error = orderline.Validate("1", "1", productId, "1");

            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void Test_quantityBlank()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string quantity = "";

            error = orderline.Validate("1", "1", "", quantity);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_quantityMinLessOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string quantity = "0";

            error = orderline.Validate("1", "1", "1", quantity);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_quantityMin()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string quantity = "1";

            error = orderline.Validate("1", "1", "1", quantity);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void Test_quantityMinPlusOne()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string quantity = "2";

            error = orderline.Validate("1", "1", "1", quantity);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void Test_quantityMid()
        {
            clsOrderLine orderline = new clsOrderLine();

            string error = "";

            string quantity = "5";

            error = orderline.Validate("1", "1", "1", quantity);

            Assert.AreEqual(error, "");
        }
    }
}
