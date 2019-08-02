using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Test
{
    [TestClass]
    public class OrderTest
    {
        
        [TestMethod]
        public void ConstructorTest_True()
        {
            Order order1 = new Order("bread", 5);
            Assert.AreEqual(typeof(Order), order1.GetType());
        }

        [TestMethod]
        public void GetAll_test()
        {
            Order.ClearAll();
            Order order1 = new Order("bread", 5);
            Order order2 = new Order("pastry", 2);
            List<Order> testList = new List<Order> { order1, order2 };
            List<Order> resultList = Order.GetAll();
           CollectionAssert.AreEqual(testList, resultList);

        }

        [TestMethod]
        public void FindOrder_test()
        {
            Order.ClearAll();
            Order order1 = new Order("bread", 5);
            Order order2 = new Order("pastry", 2);
            Order order3 = new Order("bread", 5);

            Order searchOrder2 = Order.Find(2);
            Assert.AreEqual(order2, searchOrder2);
        }
    }
}