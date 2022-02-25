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
      int result = 8;
      Assert.AreEqual(result, newOrder.GetBreadQuantity());
    }
    // [TestMethod]
    // public void GetPastryTotal_ReturnTotalPriceOfPastries_Int()
    // {
    //   int danish = 6;
    //   int bearclaw = 0;
    //   int croissant = 0;
    //   Pastry newOrder = new Pastry(danish, bearclaw, croissant);
    //   int result = 4;
    //   Assert.AreEqual(10, newOrder.GetPastryTotal());
    // }
  }
}