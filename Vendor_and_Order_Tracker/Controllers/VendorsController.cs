using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Vendor_and_Order_Tracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View();
    }
  }
}