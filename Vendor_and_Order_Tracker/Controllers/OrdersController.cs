using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Vendor_and_Order_Tracker.Models;

namespace Vendor_and_Order_Tracker.Controllers
{
  public class OrdersController : Controller
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
    }

    [HttpPost("/orders")]
    public ActionResult Create(int orderVendorId, string title, string description, int price, string orderDate, string deliveryForDate, int ryeLoaf, int wheatLoaf, int gfLoaf, int croissant, int baklava, int danish)
    {
      Order order = new Order(orderVendorId, title, description, price, orderDate, deliveryForDate, ryeLoaf, wheatLoaf, gfLoaf, croissant, baklava, danish);
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order selectedOrder = Order.FindById(id);
      return View(selectedOrder);
    }
  }
}