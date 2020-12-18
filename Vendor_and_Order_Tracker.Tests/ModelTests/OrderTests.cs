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
      
    }
  }
}