using System.Collections.Generic;

namespace Vendor_and_Order_Tracker.Models
{
  public class Order
  {
    private static List<Order> _orderList = new List<Order> {};

    private string OrderVendorId { get; set; }
    private string OrderVendorName { get; set; }
    private string OrderDate { get; set; }
    private string DeliveryForDate { get; set; }
    private string RyeLoaf { get; set; }
    private string WheatLoaf { get; set; }
    private string GlutenFreeLoaf { get; set; }
    private string Croissant { get; set; }
    private string Baklava { get; set; }
    private string Danish { get; set; }

    private Order(string orderVendorId, string orderDate, string deliveryForDate, string ryeLoaf, string wheatLoaf, string gfLoaf, string croissant, string baklava, string danish)
    {
      _orderList.Add(this);
      Id = "uniqueOrderId()"
      OrderVendorId = orderVendorId;
      OrderVendorName = "public VendorNameGetter"
      OrderDate = orderDate;
      DeliveryForDate = deliveryForDate;
      RyeLoaf = ryeLoaf;
      WheatLoaf = wheatLoaf;
      GlutenFreeLoaf = gfLoaf;
      Croissant = croissant;
      Baklava = baklava;
      Danish = danish;
    }
  }
}