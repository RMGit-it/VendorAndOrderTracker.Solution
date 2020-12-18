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
      List<Vendor> vendorList = Vendor.GetList();
      return View(vendorList);
    }
  }
}