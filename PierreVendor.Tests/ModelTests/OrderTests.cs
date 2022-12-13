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

    [TestMethod]
    public void GetDate_ReturnsDate_DateTime()
    {
      //Arrange
      string orderTitle = "Heart Coffee";
      string orderDescrip = "Bread & Pastries";
      int orderPrice = 150;
      DateTime date = new DateTime(2022, 03, 18);

      //Act
      Order newOrder = new Order(orderTitle, orderDescrip, orderPrice, date);
      DateTime result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newOrder = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newOrder, result);
    }    

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string orderTitle1 = "Heart Coffee";
      string orderDescrip1 = "Bread & Pastries";
      int orderPrice1 = 150;
      DateTime date1 = new DateTime(2022, 03, 18);
      string orderTitle2 = "Nuvrei Coffee";
      string orderDescrip2 = "Pastries";
      int orderPrice2 = 85;
      DateTime date1 = new DateTime(2022, 04, 12);
      Order newOrder1 = new Order(orderTitle1, orderDescrip1, orderPrice1, date1);
      Order newOrder2 = new Order(orderTitle2, orderDescrip2, orderPrice2, date2);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}