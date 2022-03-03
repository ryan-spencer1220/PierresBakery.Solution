using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Danish { get; set; }
    public int Bearclaw { get; set; }
    public int Croissant { get; set; }
    public Pastry(int danish, int bearclaw, int croissant)
    {
      Danish = danish;
      Bearclaw = bearclaw;
      Croissant = croissant;
    }

    public int GetPastryQuantity()
    {
      return Danish + Bearclaw + Croissant;
    }

    public int GetPastryTotal()
    {
      int quantity = GetPastryQuantity();
      if (quantity == 1 || quantity == 2) 
      {
        return quantity * 2;
      }
      else
      {
      int subTotal = quantity / 3;
      int total = subTotal * 5;
        if (quantity % 3 == 0)
        {
          return total;
        }
        else
        {
          total = 5 * subTotal;
          return total + (2 * (quantity % 3));
        }
      }
    }
  }
}