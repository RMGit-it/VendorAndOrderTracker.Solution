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
      
    }
  }
}