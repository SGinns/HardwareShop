using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HardwareTesting
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK() 
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Assert.IsNotNull(AllOrderLines);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();
            List<clsOrderLine> testList = new List<clsOrderLine>();

            clsOrderLine testItem = new clsOrderLine
            {
                OrderId = 1,
                OrderLineId = 1,
                ProductId = 1,
                Quantity = 5
            };

            testList.Add(testItem);

            orderLineCollection.orderLineList = testList;

            Assert.AreEqual(orderLineCollection.orderLineList, testList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();

            clsOrderLine testItem = new clsOrderLine();

            testItem.OrderId = 1;
            testItem.OrderLineId = 1;
            testItem.ProductId = 1;
            testItem.Quantity = 5;

            orderLineCollection.ThisOrderLine = testItem;

            Assert.AreEqual(orderLineCollection.ThisOrderLine, testItem);
        }

        [TestMethod]
        public void ListAndCountPropertyOK()
        {
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();

            List<clsOrderLine> testList = new List<clsOrderLine>();

            clsOrderLine testItem = new clsOrderLine();

            testItem.OrderId = 1;
            testItem.OrderLineId = 1;
            testItem.ProductId = 1;
            testItem.Quantity = 5;

            testList.Add(testItem);

            orderLineCollection.orderLineList = testList;

            Assert.AreEqual(orderLineCollection.orderLineList.Count, testList.Count);
        }
    }
}
