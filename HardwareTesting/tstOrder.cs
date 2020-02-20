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

            // Create New Instance of class
            clsOrder order = new clsOrder();
            // Var to store result of method
            Boolean found = false;
            // Employee no to search for 
            int orderId = 2;
            // Use the find method
            found = order.find(orderId);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Test_OrderIdIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 OrderId = 2;

            found = AnOrder.find(2);

            if (AnOrder.OrderId != OrderId)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void Test_CustomerIdIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 customerId = 12321;

            found = AnOrder.find(2);

            if (AnOrder.CustomerId != customerId)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void Test_StaffIdIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            Int32 StaffId = 1;

            found = AnOrder.find(2);

            if (AnOrder.StaffId != StaffId)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void Test_DateIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            DateTime date = Convert.ToDateTime("11/02/2020");

            found = AnOrder.find(2);

            if (AnOrder.Date != date)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void Test_DetailsIsFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean found = false;

            Boolean ok = true;

            string details = "text";

            found = AnOrder.find(2);

            if (AnOrder.Details != details)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
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
