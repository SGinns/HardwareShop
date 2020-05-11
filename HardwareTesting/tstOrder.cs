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
            int orderId = 3;
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

            Int32 OrderId = 3;

            found = AnOrder.find(3);

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

            found = AnOrder.find(3);

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

            found = AnOrder.find(3);

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

            DateTime date = Convert.ToDateTime("21/03/2020");

            found = AnOrder.find(3);

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

            found = AnOrder.find(3);

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

            AnOrder.StaffId = TestData;

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

            Int32 OrderId = 3;

            found = AnOrder.find(OrderId);

            if (AnOrder.Date != Convert.ToDateTime("16/09/2015"))
            {
                ok = false;
            }

            Assert.IsTrue(found);
        }
        [TestMethod]
        public void Test_orderIdBlank()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "";

            error = order.Validate(orderId, "1", "1", "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMinLessOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "";

            error = order.Validate(orderId, "1", "1", "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMin()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "a";

            error = order.Validate(orderId, "1", "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMinPlusOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "aa";

            error = order.Validate(orderId, "1", "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMaxLessOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "aaaaa";

            error = order.Validate(orderId, "1", "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "aaaaaa";

            error = order.Validate(orderId, "1", "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdMid()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "aaa";

            error = order.Validate(orderId, "1", "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_orderIdExtremeMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "";
            orderId = orderId.PadRight(500, 'a');

            error = order.Validate(orderId, "1", "1", "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_staffIdBlank()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string orderId = "";

            error = order.Validate(orderId, "1", "1", "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_staffIdMinLessOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string staffId = "";

            error = order.Validate("1", "1", staffId, "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_staffIdMin()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string staffId = "a";

            error = order.Validate("1", "1", staffId, DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_staffIdMinPlusOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string staffId = "aa";

            error = order.Validate("1", "1", staffId, DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_staffIdMaxLessOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string staffId = "aaaaa";

            error = order.Validate("1", "1", staffId, DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_staffIdMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string staffId = "aaaaaa";

            error = order.Validate("1", "1", staffId, DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_staffIdMid()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string staffId = "aaa";

            error = order.Validate("1", "1", staffId, DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_staffIdExtremeMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string staffId = "";
            staffId = staffId.PadRight(500, 'a');

            error = order.Validate("1", "1", staffId, "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_customerIdBlank()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string customerId = "";

            error = order.Validate("1", customerId, "1", "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_customerIdMinLessOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string customerId = "";

            error = order.Validate("1", customerId, "1", "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_customerIdMin()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string customerId = "a";

            error = order.Validate("1", customerId, "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_customerIdMinPlusOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string customerId = "aa";

            error = order.Validate("1", customerId, "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_customerIdMaxLessOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string customerId = "aaaaa";

            error = order.Validate("1", customerId, "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_customerIdMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string customerId = "aaaaaa";

            error = order.Validate("1", customerId, "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void Test_customerIdMid()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string customerId = "aaa";

            error = order.Validate("1", customerId, "1", DateTime.Now.Date.ToString(), "test");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_customerIdExtremeMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string customerId = "";
            customerId = customerId.PadRight(500, 'a');

            error = order.Validate("1", customerId, "1", "1", "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_DateExtremeMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            DateTime testDate = DateTime.Now.Date;

            testDate = testDate.AddYears(-100);

            string dateAdded = testDate.ToString();

            error = order.Validate("1", "1", "1", "1", dateAdded);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_DateExtremeMin()
        {
            clsOrder order = new clsOrder();

            string error = "";

            DateTime testDate = DateTime.Now.Date;

            testDate = testDate.AddYears(100);

            string dateAdded = testDate.ToString();

            error = order.Validate("1", "1", "1", "1", dateAdded);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_DateInvalidData()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string dateAdded = "This is an invalid date";

            error = order.Validate("1", "1", "1", "1", dateAdded);

            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void Test_detailsBlank()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string details = "";

            error = order.Validate("1", "1", "1", details, "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_detailsMinLessOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string details = "";

            error = order.Validate("1", "1", "1", details, "12/12/2020");

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void Test_detailsMin()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string details = "a";

            error = order.Validate("1", "1", "1", DateTime.Now.Date.ToString(), details);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void Test_detailsMinPlusOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string details = "aa";

            error = order.Validate("1", "1", "1", DateTime.Now.Date.ToString(), details);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void Test_detailsMaxLessOne()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string details = "";
            details = details.PadRight(99, 'a');

            error = order.Validate("1", "1", "1", DateTime.Now.Date.ToString(), details);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void Test_detailsMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string details = "";
            details = details.PadRight(100, 'a');

            error = order.Validate("1", "1", "1", DateTime.Now.Date.ToString(), details);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void Test_detailsMid()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string details = "aaa";

            error = order.Validate("1", "1", "1", DateTime.Now.Date.ToString(), details);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void Test_detailsExtremeMax()
        {
            clsOrder order = new clsOrder();

            string error = "";

            string details = "";
            details = details.PadRight(500, 'a');

            error = order.Validate("1", "1", "1", DateTime.Now.Date.ToString(), details);

            Assert.AreNotEqual(error, "");
        }
    }
}
