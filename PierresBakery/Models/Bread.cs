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
      // return _sourdough + _baguette + _pumpernickle;
      return 0;
    }

    public int GetBreadTotal()
    {
      int quantity = GetBreadQuantity();
      return quantity;
    }
  }
}