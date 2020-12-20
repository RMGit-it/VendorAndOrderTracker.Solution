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
      Assert.AreEqual("b", ven1.GetShipToName());
      Assert.AreEqual("c", ven1.GetAddress());
      Assert.AreEqual("d", ven1.GetState());
      Assert.AreEqual("e", ven1.GetCity());
      Assert.AreEqual("f", ven1.GetZipcode());
      Assert.AreEqual("g", ven1.GetPhone());
      Assert.AreEqual("h", ven1.GetEmail());
      Assert.AreEqual("VN" + DateTime.Now.ToString("yyyyMMddHHmmss"), ven1.GetVendorId());
    }

    [TestMethod]
    public void GetList_RetreiveStaticList_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Vendor ven2 = new Vendor("a","b","c","d","e","f","g","h");
      List<Vendor> list1 = new List<Vendor> { ven1, ven2 };
      CollectionAssert.AreEqual(list1, Vendor.GetList());
    }

    [TestMethod]
    public void ClearList_ReturnAnEmptyStaticList_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Vendor ven2 = new Vendor("a","b","c","d","e","f","g","h");
      Vendor.ClearList();
      int listCount = Vendor.GetList().Count;
      Assert.AreEqual(0, listCount);
    }

    [TestMethod]
    public void FindById_ReturnObjectWithMatchingIdProperty_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      string venId = ven1.GetVendorId();
      Assert.AreEqual("b", Vendor.FindById(venId).GetVendorName());
    }

  }
}