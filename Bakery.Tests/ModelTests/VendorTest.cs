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
         List<Vendor> testList = new List<Vendor>{ vendor1, vendor2};

         List<Vendor> resultList = Vendor.GetAll();

         CollectionAssert.AreEqual(testList, resultList);

        }

    }
}