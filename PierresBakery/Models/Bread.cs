using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Sourdough { get; set; }
    public int Baguette { get; set; }
    public int Pumpernickle { get; set; }
    public Bread(int sourdough, int baguette, int pumpernickle)
    {
      Sourdough = sourdough;
      Baguette = baguette;
      Pumpernickle = pumpernickle;
    }

    public int GetBreadQuantity()
    {
      return Sourdough + Baguette + Pumpernickle;
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
          return quantity * 5 - (quantity / 3 * 5);
        }
        else
        {
          return quantity * 5 - (quantity / 3 * 10);
        }
      }
    }
  }
}