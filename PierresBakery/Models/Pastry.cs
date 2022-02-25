using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    private int _danish;
    private int _bearclaw;
    private int _croissant;
    public Pastry(int danish, int bearclaw, int croissant)
    {
      _danish = danish;
      _bearclaw = bearclaw;
      _croissant = croissant;
    }

    public int GetPastryQuantity()
    {
      return _danish + _bearclaw + _croissant;
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