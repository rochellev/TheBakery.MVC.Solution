using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Test
{
    [TestClass]
    public class VendorTest
    {

        [TestMethod]
        public void ConstructorTest_True()
        {
            Vendor vendor1 = new Vendor("pippa's place", "bakery");
            Assert.AreEqual(typeof(Vendor), vendor1.GetType());
        }

        [TestMethod]
        public void GetAll_test()
        {
            Vendor.ClearAll();
            Vendor vendor1 = new Vendor("pippa's place", "bakery");
            Vendor vendor2 = new Vendor("pippa's second place", "bakery");
            List<Vendor> testList = new List<Vendor> { vendor1, vendor2 };

            List<Vendor> resultList = Vendor.GetAll();

            CollectionAssert.AreEqual(testList, resultList);

        }

        [TestMethod]
        public void FindVendor_Test()
        {
            Vendor.ClearAll();
            Vendor vendor1 = new Vendor("pippa's place", "bakery");
            Vendor vendor2 = new Vendor("pippa's second place", "bakery");
            Vendor searchV2 = Vendor.Find(2);
            Assert.AreEqual(vendor2, searchV2);
        }

        [TestMethod]
        public void AddOrder_Test()
        {
            Vendor.ClearAll();
            Order.ClearAll();
            Vendor vendor1 = new Vendor("pippa's place", "bakery");
            Vendor vendor2 = new Vendor("pippa's second place", "bakery");
            Order order1 = new Order("baked goods", 20);
            vendor1.AddOrder(order1);

            List<Order> testOrderList = new List<Order>{order1};

            CollectionAssert.AreEqual(testOrderList, vendor1.Orders);

            
        }

    }
}