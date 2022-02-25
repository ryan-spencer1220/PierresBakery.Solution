using System.Collections.Generic;

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
        return 0;
      // int quantity = GetPastryQuantity();
      // if (quantity == 1 || quantity == 2) 
      // {
      //   return quantity * 2;
      // }
      // else
      // {
      //   int deals = Math.Floor(quantity / 3);
      //   if (quantity % 3 < 0.5)
      //   {
      //     return deals + 1;
      //   }
      //   else
      //   {
      //     return deals + 2;
      //   }
      // }
    }
  }
}