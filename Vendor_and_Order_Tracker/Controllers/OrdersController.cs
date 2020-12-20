using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Vendor_and_Order_Tracker.Models;

namespace Vendor_and_Order_Tracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> orderList = Order.GetList();
      return View(orderList);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      List<Vendor> vendorList = Order.VendorGetList();
      return View(vendorList);
      // return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string orderVendorId, string orderDate, string deliveryForDate, string ryeLoaf, string wheatLoaf, string gfLoaf, string croissant, string baklava, string danish)
    {
      Order order = new Order(orderVendorId, orderDate, deliveryForDate, ryeLoaf, wheatLoaf, gfLoaf, croissant, baklava, danish);
      return RedirectToAction("Index");
    }
  }
}