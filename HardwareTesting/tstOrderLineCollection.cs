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

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderLineCollection orderLines = new clsOrderLineCollection();

            clsOrderLine orderLine = new clsOrderLine
            {
                OrderId = 3,
                OrderLineId = 1,
                ProductId = 1,
                Quantity = 5
            };

            Int32 primaryKey = 0;

            orderLines.ThisOrderLine = orderLine;

            primaryKey = orderLines.Add();

            orderLine.OrderLineId = primaryKey;

            orderLines.ThisOrderLine.find(primaryKey);

            Assert.AreEqual(orderLines.ThisOrderLine, orderLine);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderLineCollection orderLines = new clsOrderLineCollection();

            clsOrderLine orderLine = new clsOrderLine
            {
                OrderId = 3,
                OrderLineId = 1,
                ProductId = 1,
                Quantity = 5
            };

            Int32 primaryKey = 0;

            orderLines.ThisOrderLine = orderLine;

            primaryKey = orderLines.Add();

            orderLine.OrderLineId = primaryKey;

            orderLines.ThisOrderLine.find(primaryKey);

            orderLines.Delete();

            Assert.IsFalse(orderLines.ThisOrderLine.find(primaryKey));
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderLineCollection orderLines = new clsOrderLineCollection();

            clsOrderLine orderLine = new clsOrderLine
            {
                OrderLineId = 1,
                OrderId = 3,
                ProductId = 1,
                Quantity = 10
            };

            Int32 primaryKey = 0;

            orderLines.ThisOrderLine = orderLine;

            primaryKey = orderLines.Add();

            orderLine.OrderLineId = primaryKey;

            orderLine = new clsOrderLine
            {
                OrderLineId = 1,
                OrderId = 4,
                ProductId = 2,
                Quantity = 5
            };

            orderLines.ThisOrderLine = orderLine;

            orderLines.Update();

            orderLines.ThisOrderLine.find(primaryKey);

            Assert.AreEqual(orderLines.ThisOrderLine, orderLine);
        }
    }
}
