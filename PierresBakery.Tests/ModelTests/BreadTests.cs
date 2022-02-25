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
    // [TestMethod]
    // public void GetPastryQuantity_ReturnTotalQuantityOfPastries_Int()
    // {
    //   int danish = 1;
    //   int bearclaw = 2;
    //   int croissant = 1;
    //   Pastry newOrder = new Pastry(danish, bearclaw, croissant);
    //   int result = 4;
    //   Assert.AreEqual(4, newOrder.GetPastryQuantity());
    // }
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