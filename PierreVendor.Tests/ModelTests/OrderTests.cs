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
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      DateTime date = new DateTime(2022, 03, 18);
      Order newOrder = new Order("Heart Coffee order", "Bread & Pastries", 150, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string orderTitle = "Heart Coffee";
      string orderDescrip = "Bread & Pastries";
      int orderPrice = 150;
      DateTime date = new DateTime(2022, 03, 18);

      //Act
      Order newOrder = new Order(orderTitle, orderDescrip, orderPrice, date);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string orderTitle = "Heart Coffee";
      string orderDescrip = "Bread & Pastries";
      int orderPrice = 150;
      DateTime date = new DateTime(2022, 03, 18);

      //Act
      Order newOrder = new Order(orderTitle, orderDescrip, orderPrice, date);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(orderDescrip, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      //Arrange
      string orderTitle = "Heart Coffee";
      string orderDescrip = "Bread & Pastries";
      int orderPrice = 150;
      DateTime date = new DateTime(2022, 03, 18);

      //Act
      Order newOrder = new Order(orderTitle, orderDescrip, orderPrice, date);
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(orderPrice, result);
    }
  }
}