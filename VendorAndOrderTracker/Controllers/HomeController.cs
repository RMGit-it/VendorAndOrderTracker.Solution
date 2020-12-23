using Microsoft.AspNetCore.Mvc;

namespace Vendor_and_Order_Tracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}