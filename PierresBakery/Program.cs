using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━╮╱╱╱╭╮");
      Console.WriteLine("┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╭╮╱╱╱┃╭╮┃╱╱╱┃┃");
      Console.WriteLine("┃╰━╯┣┳━━┳━┳━┳━━┫┣━━╮┃╰╯╰┳━━┫┃╭┳━━┳━┳╮╱╭╮");
      Console.WriteLine("┃╭━━╋┫┃━┫╭┫╭┫┃━╋┫━━┫┃╭━╮┃╭╮┃╰╯┫┃━┫╭┫┃╱┃┃");
      Console.WriteLine("┃┃╱╱┃┃┃━┫┃┃┃┃┃━┫┣━━┃┃╰━╯┃╭╮┃╭╮┫┃━┫┃┃╰━╯┃");
      Console.WriteLine("╰╯╱╱╰┻━━┻╯╰╯╰━━╯╰━━╯╰━━━┻╯╰┻╯╰┻━━┻╯╰━╮╭╯");
      Console.WriteLine("╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━╯┃");
      Console.WriteLine("╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╰━━╯");
      Console.WriteLine("-----------------------------------------");
      
      Console.WriteLine("Hello! Welcome to Pierre's Bakery!");
      Console.WriteLine("Can I interest you in some pastries? How many Danishes can I put you down for?");
      int danishQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("Would you like any bearclaws? Please enter a quantity!");
      int bearclawQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("Perfect, and finally, how many croissants would you like?");
      int croissantQuantity = int.Parse(Console.ReadLine());

      Pastry pastryOrder = new Pastry(danishQuantity, bearclawQuantity, croissantQuantity);
      Console.WriteLine("Thank you so much for your order! Your total will be $" + pastryOrder.GetPastryTotal() + ".00");
    }
  }
}