using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;


namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetList();
      return View(vendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string shipToName, string shipAddress, string shipState, string shipCity, string shipZip, string phoneNum, string email)
    {
      Vendor vendor = new Vendor(vendorName, shipToName, shipAddress, shipState, shipCity, shipZip, phoneNum, email);
      return RedirectToAction("Index", "Home");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor selectedVendor = Vendor.FindById(id);
      List<Order> orderList = Order.GetList();
      List<Vendor> vendorList = new List<Vendor> { selectedVendor };
      List<Object> objectList = new List<Object> { vendorList, orderList };

      return View(objectList);
    }
  }
}