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
            Vendor vendor1 = new Vendor("pippa's place");
            Assert.AreEqual(typeof(Vendor), vendor1.GetType());
        }

        [TestMethod]
        public void GetAll_test()
        {
            

        }

    }
}