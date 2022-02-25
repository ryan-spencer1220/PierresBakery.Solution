using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreateInstanceOfBreadOrder_Bread()
    {
      Bread newOrder = new Bread(1, 2, 1);
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }
    [TestMethod]
    public void GetBreadQuantity_ReturnTotalQuantityOfBreads_Int()
    {
      int sourdough = 0;
      int baguette = 5;
      int pumpernickle = 3;
      Bread newOrder = new Bread(sourdough, baguette, pumpernickle);
      Assert.AreEqual(8, newOrder.GetBreadQuantity());
    }
    [TestMethod]
    public void GetBreadTotal_ReturnTotalPriceOfBreads_Int()
    {
      int sourdough = 6;
      int baguette = 0;
      int pumpernickle = 0;
      Bread newOrder = new Bread(sourdough, baguette, pumpernickle);
      Assert.AreEqual(20, newOrder.GetBreadTotal());
    }
  }
}