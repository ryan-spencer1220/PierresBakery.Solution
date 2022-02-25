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
      int result = 4;
      Assert.AreEqual(4, newOrder.GetPastryQuantity());
    }
  }
}