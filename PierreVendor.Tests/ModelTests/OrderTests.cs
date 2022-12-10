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
      DateTime date = new DateTime(2022, 03, 18);
      Order newOrder = new Order("Heart Coffee order", "Bread & Pastries", 150, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}