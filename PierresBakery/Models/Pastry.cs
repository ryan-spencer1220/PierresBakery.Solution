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
      return 0;
    }
  }
}