using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Vendor_and_Order_Tracker.Models;


namespace Vendor_and_Order_Tracker.Controllers
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
      return RedirectToAction("Index");
    }
  }
}