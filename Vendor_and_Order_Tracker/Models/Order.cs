using System.Collections.Generic;
using System;
using System.Linq;

namespace Vendor_and_Order_Tracker.Models
{
  public class Order
  {
    private static List<Order> _orderList = new List<Order> {};

    private string OrderVendorId { get; set; }
    // private string OrderVendorName { get; set; }
    private string OrderId { get; set; }
    private string OrderDate { get; set; }
    private string DeliveryForDate { get; set; }
    private string RyeLoaf { get; set; }
    private string WheatLoaf { get; set; }
    private string GlutenFreeLoaf { get; set; }
    private string Croissant { get; set; }
    private string Baklava { get; set; }
    private string Danish { get; set; }

    public Order(string orderVendorId, string orderDate, string deliveryForDate, string ryeLoaf, string wheatLoaf, string gfLoaf, string croissant, string baklava, string danish)
    {
      _orderList.Add(this);
      OrderId = "OR" + DateTime.Now.ToString("yyyyMMddHHmmss");
      OrderVendorId = orderVendorId;
      // OrderVendorName = orderVendorName;
      OrderDate = orderDate;
      DeliveryForDate = deliveryForDate;
      RyeLoaf = ryeLoaf;
      WheatLoaf = wheatLoaf;
      GlutenFreeLoaf = gfLoaf;
      Croissant = croissant;
      Baklava = baklava;
      Danish = danish;
    }

    public static void ClearList()
    {
      _orderList.Clear();
    }

    public static List<Order> GetList()
    {
      return _orderList;
    }

    public string GetOrderId()
    {
      return this.OrderId;
    }

    public string GetOrderVendorId()
    {
      return this.OrderVendorId;
    }

    // public string GetOrderVendorName()
    // {
    //   return this.OrderVendorName;
    // }

    public string GetOrderDate()
    {
      return this.OrderDate;
    }

    public string GetDeliveryForDate()
    {
      return this.DeliveryForDate;
    }

    public string GetRyeLoaf()
    {
      return this.RyeLoaf;
    }

    public string GetWheatLoaf()
    {
      return this.WheatLoaf;
    }

    public string GetGlutenFreeLoaf()
    {
      return this.GlutenFreeLoaf;
    }

    public string GetCroissant()
    {
      return this.Croissant;
    }

    public string GetBaklava()
    {
      return this.Baklava;
    }

    public string GetDanish()
    {
      return this.Danish;
    }
    
    public static List<Vendor> VendorGetList()
    {
      return Vendor.GetList();
    }
  }
}