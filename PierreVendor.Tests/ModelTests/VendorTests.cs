using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendor.Models;
using System.Collections.Generic;
using System;

namespace PierreVendor.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Heart Coffee", "Coffee Shop");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameOfVendor_ReturnsNameOfVendor_String()
    {
      //Arrange
      string name = "Heart Coffee";
      string description = "Coffee Shop";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.NameOfVendor;

      //Assert
      Assert.AreEqual(name, result);
    }
    
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Heart Coffee";
      string description = "Coffee Shop";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetDescripOfVendor_ReturnsDescripOfVendor_String()
    {
      //Arrange
      string name = "Heart Coffee";
      string description = "Coffee Shop";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.DescripOfVendor;

      //Assert
      Assert.AreEqual(description, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Heart Coffee";
      string description01 = "Coffee Shop";
      string name02 = "Nuvrei Coffee";
      string description02 = "Coffee Shop";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Heart Coffee";
      string description01 = "Coffee Shop";
      string name02 = "Nuvrei Coffee";
      string description02 = "Coffee Shop";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
    
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Heart Coffee";
      string description = "Coffee shop";
      int totalLoaves = 2;
      int totalPastries = 3;
      DateTime date = new DateTime(2022, 03, 18);
      Order newOrder = new Order(title, description, totalLoaves, totalPastries, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Heart Coffee";
      string vendDescription = "Coffee Shop";
      Vendor newVendor = new Vendor(name, vendDescription);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}