using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HardwareTesting
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK() 
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();
            List<clsOrder> testList = new List<clsOrder>();

            clsOrder testItem = new clsOrder();

            testItem.OrderId = 1;
            testItem.StaffId = 1;
            testItem.CustomerId = 1;
            testItem.Date = DateTime.Now.Date;
            testItem.Details = "test";

            testList.Add(testItem);

            orderCollection.orderList = testList;

            Assert.AreEqual(orderCollection.orderList, testList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();

            clsOrder testItem = new clsOrder();

            testItem.OrderId = 1;
            testItem.StaffId = 1;
            testItem.CustomerId = 1;
            testItem.Date = DateTime.Now.Date;
            testItem.Details = "test";

            orderCollection.ThisOrder = testItem;

            Assert.AreEqual(orderCollection.ThisOrder, testItem);
        }

        [TestMethod]
        public void ListAndCountPropertyOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();

            List<clsOrder> testList = new List<clsOrder>();

            clsOrder testItem = new clsOrder();

            testItem.OrderId = 1;
            testItem.StaffId = 1;
            testItem.CustomerId = 1;
            testItem.Date = DateTime.Now.Date;
            testItem.Details = "test";

            testList.Add(testItem);

            orderCollection.orderList = testList;

            Assert.AreEqual(orderCollection.orderList.Count, testList.Count);
        }
    }
}
