using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor_and_Order_Tracker.Models;
using System.Collections.Generic;
using System;

namespace Vendor_and_Order_Tracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearList();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_True()
    {
      Order ord1 = new Order("a","b","c","d","e","f","g","h", "i");
      Assert.AreEqual(typeof(Order), ord1.GetType());
    }
  }
}