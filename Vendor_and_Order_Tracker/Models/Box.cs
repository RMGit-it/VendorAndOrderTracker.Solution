using System.Collections.Generic;
using System;
using System.Linq;

namespace Vendor_and_Order_Tracker.Models
{
  public class Order
  {
    public List<Vendors> BoxVendor { get; set; }
    public List<Orders> BoxOrder { get; set; }

    public Order (List<Vendor> Vendor.GetList(), List<Order> Order.GetList())
    {
      BoxVendor = Vendor.GetList();
      BoxOrder = Order.GetList();
    }
  }
}  