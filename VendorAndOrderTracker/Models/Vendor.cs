using System.Collections.Generic;
using System;
using System.Linq;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorList = new List<Vendor> {};

    private int Id { get; set; }
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
      Id = ListId();
      VendorId = "VN" + DateTime.Now.ToString("yyyyMMddHHmmss");
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

    public string GetVendorId()
    {
      return this.VendorId;
    }

    public string GetVendorName()
    {
      return this.VendorName;
    }

    public string GetShipToName()
    {
      return this.ShipToName;
    }

    public string GetAddress()
    {
      return this.Address;
    }

    public string GetState()
    {
      return this.State;
    }

    public string GetCity()
    {
      return this.City;
    }

    public string GetZipcode()
    {
      return this.Zipcode;
    }

    public string GetPhone()
    {
      return this.Phone;
    }

    public string GetEmail()
    {
      return this.Email;
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
        if(_vendorList.Exists(x => x.Id == i))
        {
        }
        else
        {
          return Num += i;
        }
      }
      return Num;
    }

    public static Vendor FindById(int inputId)
    {
      return _vendorList[_vendorList.FindIndex(x => x.Id == inputId)];
    }
    
  }
}