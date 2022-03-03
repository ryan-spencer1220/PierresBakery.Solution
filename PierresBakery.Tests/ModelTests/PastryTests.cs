using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreateInstanceOfPastryOrder_Pastry()
    {
      Pastry newOrder = new Pastry(1, 2, 1);
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }
    [TestMethod]
    public void GetPastryQuantity_ReturnTotalQuantityOfPastries_Int()
    {
      int danish = 1;
      int bearclaw = 2;
      int croissant = 1;
      Pastry newOrder = new Pastry(danish, bearclaw, croissant);
      Assert.AreEqual(4, newOrder.GetPastryQuantity());
    }
    [TestMethod]
    public void GetPastryTotal_ReturnTotalPriceOfPastries_Int()
    {
      int danish = 6;
      int bearclaw = 0;
      int croissant = 0;
      Pastry newOrder = new Pastry(danish, bearclaw, croissant);
      Assert.AreEqual(10, newOrder.GetPastryTotal());
    }
    [TestMethod]
    public void GetPastryTotal2_ReturnTotalPriceOfPastries_Int()
    {
      int danish = 7;
      int bearclaw = 0;
      int croissant = 0;
      Pastry newOrder = new Pastry(danish, bearclaw, croissant);
      Assert.AreEqual(12, newOrder.GetPastryTotal());
    }
    [TestMethod]
    public void GetPastryTotal3_ReturnTotalPriceOfPastries_Int()
    {
      int danish = 8;
      int bearclaw = 0;
      int croissant = 0;
      Pastry newOrder = new Pastry(danish, bearclaw, croissant);
      Assert.AreEqual(14, newOrder.GetPastryTotal());
    }
    [TestMethod]
    public void GetPastryTotal4_ReturnTotalPriceOfPastries_Int()
    {
      int danish = 9;
      int bearclaw = 0;
      int croissant = 0;
      Pastry newOrder = new Pastry(danish, bearclaw, croissant);
      Assert.AreEqual(15, newOrder.GetPastryTotal());
    }
  }
}