using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor_and_Order_Tracker.Models;
using System.Collections.Generic;
using System;

namespace Vendor_and_Order_Tracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearList();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Assert.AreEqual(typeof(Vendor), ven1.GetType());
    }
  }
}