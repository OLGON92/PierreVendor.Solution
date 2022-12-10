using System.Collections.Generic;

namespace PierreVendor.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Loaves { get; set; }
    public int Pastries { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public int GetOrderTotal(int totalLoaves, int totalPastries)
    {
      int loafPrice;
      int pastryPrice;
      int grandTotal;

      if(totalLoaves <= 50)
      {
        loafPrice = 5;
      } 
      else if(totalLoaves >=51 && totalLoaves <=100)
      {
        loafPrice = 4;
      } 
      else
      {
        loafPrice = 3;
      }

      if(totalPastries <= 25)
      {
        pastryPrice = 4;
      }
      else if(totalPastries >= 26 && totalPastries <=50)
      {
        pastryPrice = 3;
      }
      else
      {
        pastryPrice = 2;
      }

      return grandTotal = (totalPastries * pastryPrice) + (totalLoaves * loafPrice);
    }
    
    public Order(string title, string description, int totalLoaves, int totalPastries, DateTime date)
    {
      Title = title;
      Description = description;
      Loaves = totalLoaves;
      Pastries = totalPastries;
      Price = GetOrderTotal(totalLoaves, totalPastries);
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}