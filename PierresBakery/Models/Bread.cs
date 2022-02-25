using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    private int _sourdough;
    private int _baguette;
    private int _pumpernickle;
    public Bread(int sourdough, int baguette, int pumpernickle)
    {
      _sourdough = sourdough;
      _baguette = baguette;
      _pumpernickle = pumpernickle;
    }

    public int GetBreadQuantity()
    {
      return _sourdough + _baguette + _pumpernickle;
    }

    public int GetBreadTotal()
    {
      int quantity = GetBreadQuantity();
      if (quantity == 1 || quantity == 2)
      {
        return quantity * 5;
      }
      else
      {
        if (quantity % 3 == 0)
        {
          return quantity * 5 - (quantity / 3 * 5);
        }
        else if (quantity % 3 < 5)
        {
          return quantity * 5 - (quantity / 3 * 5) + 5;
        }
        else
        {
          return quantity * 5 - (quantity / 3 * 5) + 10;
        }
      }
    }
  }
}