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
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_True()
    {
      Order ord1 = new Order("a","b","c","d","e","f","g","h", "i");
      Assert.AreEqual(typeof(Order), ord1.GetType());
    }

    [TestMethod]
    public void GetVariousOrderProperties_ReturnVariousPropertiesOfOrder_true()
    {
      Order ord1 = new Order("a","b","c","d","e","f","g","h","i");
      Assert.AreEqual("a", ord1.GetOrderVendorId());
      Assert.AreEqual("b", ord1.GetOrderDate());
      Assert.AreEqual("c", ord1.GetDeliveryForDate());
      Assert.AreEqual("d", ord1.GetRyeLoaf());
      Assert.AreEqual("e", ord1.GetWheatLoaf());
      Assert.AreEqual("f", ord1.GetGlutenFreeLoaf());
      Assert.AreEqual("g", ord1.GetCroissant());
      Assert.AreEqual("h", ord1.GetBaklava());
      Assert.AreEqual("i", ord1.GetDanish());
      Assert.AreEqual("OR" + String.Concat(DateTime.Now.ToString().Where(x => !Char.IsWhiteSpace(x))), ord1.GetOrderId());
    }

    [TestMethod]
    public void GetList_RreturnStaticList_True()
    {
      Order ord1 = new Order("a","b","c","d","e","f","g","h","i");
      Order ord2 = new Order("a","b","c","d","e","f","g","h","i");
      List<Order> list1 = new List<Order> { ord1, ord2 };
      CollectionAssert.AreEqual(list1, Order.GetList());
    }
  }
}