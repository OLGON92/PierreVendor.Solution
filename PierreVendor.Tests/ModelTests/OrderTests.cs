using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVendor.Models;
using System;

namespace PierreVendor.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(title, description, totalLoaves, totalPastries, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}