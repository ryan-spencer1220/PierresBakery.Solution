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
  }
}