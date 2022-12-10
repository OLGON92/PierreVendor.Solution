using System.Collections.Generic;
using System;

namespace PierreVendor.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string NameOfVendor { get; set; }
    public string DescripOfVendor { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      NameOfVendor = name;
      DescripOfVendor = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}