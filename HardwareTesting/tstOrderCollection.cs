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

        [TestMethod]
        public void AddMethodOK() 
        {
            clsOrderCollection orders = new clsOrderCollection();

            clsOrder order = new clsOrder
            {
                OrderId = 1,
                CustomerId = 1,
                Date = DateTime.Now.Date,
                Details = "Text",
                StaffId = 1
            };

            Int32 primaryKey = 0;

            orders.ThisOrder = order;

            primaryKey = orders.Add();

            order.OrderId = primaryKey;

            orders.ThisOrder.find(primaryKey);

            Assert.AreEqual(orders.ThisOrder, order);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection orders = new clsOrderCollection();

            clsOrder order = new clsOrder
            {
                OrderId = 1,
                CustomerId = 1,
                Date = DateTime.Now.Date,
                StaffId = 1,
                Details = "Text"
            };

            Int32 primaryKey = 0;

            orders.ThisOrder = order;

            primaryKey = orders.Add();

            order.OrderId = primaryKey;

            orders.ThisOrder.find(primaryKey);

            orders.Delete();

            Assert.IsFalse(orders.ThisOrder.find(primaryKey));
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection orders = new clsOrderCollection();

            clsOrder order = new clsOrder
            {
                OrderId = 3,
                CustomerId = 1,
                Date = DateTime.Now.Date,
                StaffId = 1,
                Details = "Text"
            };

            Int32 primaryKey = 0;

            orders.ThisOrder = order;

            primaryKey = orders.Add();

            order.OrderId = primaryKey;

            order = new clsOrder 
            {
                OrderId = 9,
                CustomerId = 2,
                Date = DateTime.Now.Date.AddDays(3),
                StaffId = 1,
                Details = "Test"
            };

            orders.ThisOrder = order;

            orders.Update();

            orders.ThisOrder.find(primaryKey);

            Assert.AreEqual(orders.ThisOrder, order);
        }

        [TestMethod]
        public void FilterByDetailsOK() 
        {
            clsOrderCollection orders = new clsOrderCollection();

            clsOrderCollection filteredOrders = new clsOrderCollection();

            filteredOrders.ReportByDetails("xxx");

            Assert.AreEqual(2, filteredOrders.orderList.Count);
        }

        [TestMethod]
        public void ReportByDetailsTestDataFound()
        {
            clsOrderCollection filteredOrders = new clsOrderCollection();

            Boolean OK = true;

            filteredOrders.ReportByDetails("xxx");

            if (filteredOrders.orderList.Count == 2)
            {
                if (filteredOrders.orderList[0].OrderId == 13 && filteredOrders.orderList[1].OrderId == 14)
                {
                    OK = true;
                }
            }
            else 
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
