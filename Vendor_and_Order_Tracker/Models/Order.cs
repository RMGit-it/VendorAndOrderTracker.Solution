using System.Collections.Generic;
using System;
using System.Linq;

namespace Vendor_and_Order_Tracker.Models
{
  public class Order
  {
    private static List<Order> _orderList = new List<Order> {};

    private int OrderVendorId { get; set; }
    private string OrderVendorUniqueId { get; set; }
    private string OrderVendorName { get; set; }
    private int Id { get; set; }
    private string OrderId { get; set; }

    private string Title { get; set; }

    private string Description { get; set; }

    private int Price { get; set; }
    private string OrderDate { get; set; }
    private string DeliveryForDate { get; set; }
    private int RyeLoaf { get; set; }
    private int WheatLoaf { get; set; }
    private int GlutenFreeLoaf { get; set; }
    private int Croissant { get; set; }
    private int Baklava { get; set; }
    private int Danish { get; set; }

    public Order(int orderVendorId, string title, string description, int price, string orderDate, string deliveryForDate, int ryeLoaf, int wheatLoaf, int gfLoaf, int croissant, int baklava, int danish)
    {
      _orderList.Add(this);
      Id = ListId();
      OrderId = "OR" + DateTime.Now.ToString("yyyyMMddHHmmss");
      OrderVendorId = orderVendorId;
      OrderVendorUniqueId = Vendor.FindById(orderVendorId).GetVendorId();
      OrderVendorName = Vendor.FindById(orderVendorId).GetVendorName();
      Title = title;
      Description = description;
      Price = price;
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

    public int GetOrderVendorId()
    {
      return this.OrderVendorId;
    }

    public string GetOrderVendorName()
    {
      return this.OrderVendorName;
    }

    public string GetTitle()
    {
      return this.Title;
    }

    public string GetDescription()
    {
      return this.Description;
    }

    public int GetPrice()
    {
      return this.Price;
    }

    public string GetOrderDate()
    {
      return this.OrderDate;
    }

    public string GetDeliveryForDate()
    {
      return this.DeliveryForDate;
    }

    public int GetRyeLoaf()
    {
      return this.RyeLoaf;
    }

    public int GetWheatLoaf()
    {
      return this.WheatLoaf;
    }

    public int GetGlutenFreeLoaf()
    {
      return this.GlutenFreeLoaf;
    }

    public int GetCroissant()
    {
      return this.Croissant;
    }

    public int GetBaklava()
    {
      return this.Baklava;
    }

    public int GetDanish()
    {
      return this.Danish;
    }

    public string GetOrderVendorUniqueId()
    {
      return this.OrderVendorUniqueId;
    }

    public int GetListId()
    {
      return this.Id;
    }

        public int ListId()
    {
      int Num = 0;
      for (int i=1; i <= 10000; i++)
      {
        if(_orderList.Exists(x => x.Id == i))
        {
        }
        else
        {
          return Num += i;
        }
      }
      return Num;
    }
    
    public static List<Vendor> VendorGetList()
    {
      return Vendor.GetList();
    }

    public static Order FindById(int inputId)
    {
      return _orderList[_orderList.FindIndex(x => x.Id == inputId)];
    }

  }
}