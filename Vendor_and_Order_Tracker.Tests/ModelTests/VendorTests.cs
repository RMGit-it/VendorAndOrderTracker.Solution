using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor_and_Order_Tracker.Models;
using System.Collections.Generic;
using System;
using System.Linq;

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

    [TestMethod]
    public void GetVariousProperties_ReturnVariousPropertiesOfVendor_True()
    {
    Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
    Assert.AreEqual("a", ven1.GetVendorName());
    Assert.AreEqual("b1", ven1.GetShipToName());
    Assert.AreEqual("c1", ven1.GetAddress());
    Assert.AreEqual("d1", ven1.GetState());
    Assert.AreEqual("e1", ven1.GetCity());
    Assert.AreEqual("f1", ven1.GetZipcode());
    Assert.AreEqual("g1", ven1.GetPhone());
    Assert.AreEqual("h1", ven1.GetEmail());
    Assert.AreEqual("VN1" + String.Concat(DateTime.Now.ToString().Where(x => !Char.IsWhiteSpace(x))), ven1.GetVendorId());
    }



  }
}