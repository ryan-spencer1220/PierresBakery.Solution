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
        int total = (quantity / 3) * 5;
        if (quantity % 3 < 5 && quantity % 3 > 0)
        {
          return total + 2;
        }
        else if (quantity % 3 > 5 && quantity % 3 < 1)
        {
          return total + 4;
        }
        else
        {
          return total;
        }
      }
    }
  }
}