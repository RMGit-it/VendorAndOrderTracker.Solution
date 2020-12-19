using System.Collections.Generic;
using System;

namespace Vendor_and_Order_Tracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorList = new List<Vendor> {};

    private string VendorName { get; set; }
    private string VendorId { get; set; }
    private string ShipToName { get; set; }
    private string Address { get; set; }
    private string State { get; set; }
    private string City { get; set; }
    private string Zipcode { get; set; }
    private string Phone { get; set; }
    private string Email { get; set; }

    public Vendor(string vendorName, string shipToName, string shipAddress, string shipState, string shipCity, string shipZip, string phoneNum, string email)
    {
      _vendorList.Add(this);
      VendorId = "VN" + Vendor.DateTime();
      VendorName = vendorName;
      ShipToName = shipToName;
      Address = shipAddress;
      State = shipState;
      City = shipCity;
      Zipcode = shipZip;
      Phone = phoneNum;
      Email = email;
    }

    public static void ClearList()
    {
      _vendorList.Clear();
    }

    public static List<Vendor> GetList()
    {
      return _vendorList;
    }

    public static string DateTime()
    {
      DateTime now = new DateTime();
      return now.ToString();
    }

    public string GetVendorId()
    {
      return this.VendorId;
    }

    public string GetVendorName()
    {
      return this.VendorName;
    }
  }
}