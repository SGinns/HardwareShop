using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareClasses;

namespace HardwareTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void Test_isInstanceOk()
        {
            clsOrder order = new clsOrder();
            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void Test_findMethodExists() {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrder.find(OrderId);

            if (AnOrder.OrderId != 2)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_OrderIdIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrder.find(OrderId);

            if (AnOrder.OrderId != 2)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_CustomerIdIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrder.find(OrderId);

            if (AnOrder.CustomerId != 1)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_StaffIdIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrder.find(OrderId);

            if (AnOrder.StaffId != 1)
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_DateIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrder.find(OrderId);

            if (AnOrder.Date != Convert.ToDateTime("11/02/2020 17:00:53"))
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_DetailsIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrder.find(OrderId);

            if (AnOrder.Details != "text")
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_CustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();

            int TestData = 1;

            AnOrder.CustomerId = 1;

            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void Test_StafIdFound()
        {
            clsOrder AnOrder = new clsOrder();

            int TestData = 1;

            AnOrder.StaffId = 1;

            Assert.AreEqual(AnOrder.StaffId, TestData);
        }

        [TestMethod]
        public void Test_DateFound()
        {
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = Convert.ToDateTime("16/09/2015");

            AnOrder.Date = Convert.ToDateTime("16/09/2015");

            Assert.AreEqual(AnOrder.Date, TestData);
        }

        [TestMethod]
        public void Test_Details()
        {
            clsOrder AnOrder = new clsOrder();

            string TestData = "text";

            AnOrder.Details = "text";

            Assert.AreEqual(AnOrder.Details, TestData);
        }

        [TestMethod]
        public void Test_DateAddedFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrder.find(OrderId);

            if (AnOrder.Date != Convert.ToDateTime("16/09/2015"))
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }
    }
}
