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
    /*
    [TestMethod]
    public void Find_ReturnsCorrectCategory_Category()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      Category newCategory1 = new Category(name01);
      Category newCategory2 = new Category(name02);

      //Act
      Category result = Category.Find(2);

      //Assert
      Assert.AreEqual(newCategory2, result);
    }

    [TestMethod]
    public void AddItem_AssociatesItemWithCategory_ItemList()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      List<Item> newList = new List<Item> { newItem };
      string name = "Work";
      Category newCategory = new Category(name);
      newCategory.AddItem(newItem);

      //Act
      List<Item> result = newCategory.Items;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }*/
  }
}