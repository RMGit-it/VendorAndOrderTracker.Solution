using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor_and_Order_Tracker.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Vendor_and_Order_Tracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearList();
      Vendor.ClearList();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Order ord1 = new Order(1,"od","dfd",1,1,1,1,1,1);
      Assert.AreEqual(typeof(Order), ord1.GetType());
    }

    [TestMethod]
    public void GetVariousOrderProperties_ReturnVariousPropertiesOfOrder_true()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Order ord1 = new Order(1,"od","dfd",1,1,1,1,1,1);
      Assert.AreEqual(1, ord1.GetOrderVendorId());
      Assert.AreEqual("od", ord1.GetOrderDate());
      Assert.AreEqual("dfd", ord1.GetDeliveryForDate());
      Assert.AreEqual(1, ord1.GetRyeLoaf());
      Assert.AreEqual(1, ord1.GetWheatLoaf());
      Assert.AreEqual(1, ord1.GetGlutenFreeLoaf());
      Assert.AreEqual(1, ord1.GetCroissant());
      Assert.AreEqual(1, ord1.GetBaklava());
      Assert.AreEqual(1, ord1.GetDanish());
      Assert.AreEqual("OR" + DateTime.Now.ToString("yyyyMMddHHmmss"), ord1.GetOrderId());
    }

    [TestMethod]
    public void GetList_RreturnStaticList_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Order ord1 = new Order(1,"od","dfd",1,1,1,1,1,1);
      Order ord2 = new Order(1,"od","dfd",1,1,1,1,1,1);
      List<Order> list1 = new List<Order> { ord1, ord2 };
      CollectionAssert.AreEqual(list1, Order.GetList());
    }

    [TestMethod]
    public void ClearList_ReturnAnEmptyList_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Order ord1 = new Order(1,"od","dfd",1,1,1,1,1,1);
      Order ord2 = new Order(1,"od","dfd",1,1,1,1,1,1);
      Order.ClearList();
      int listCount = Order.GetList().Count;
      Assert.AreEqual(0, listCount);
    }

    [TestMethod]
    public void FindById_ReturnObjectWithMatchingIdProperty_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Order ord1 = new Order(1,"od","dfd",1,1,1,1,1,1);
      int ordId = ord1.GetListId();
      Assert.AreEqual(1, Order.FindById(ordId).GetRyeLoaf());
    }

    [TestMethod]
    public void GetListId_GetListIdValue_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Order ord1 = new Order(1,"od","dfd",1,1,1,1,1,1);
      Order ord2 = new Order(1,"od","dfd",1,1,1,1,1,1);
      Order ord3 = new Order(1,"od","dfd",1,1,1,1,1,1);
      Assert.AreEqual(2, ord3.GetListId());
    }

  }
}