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
      Console.WriteLine("╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━╮╱╱╱╭╮");
      Console.WriteLine("┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╭╮╱╱╱┃╭╮┃╱╱╱┃┃");
      Console.WriteLine("┃╰━╯┣┳━━┳━━┳━━┳━━┫┣━━╮┃╰╯╰┳━━┫┃╭┳━━┳━┳╮╱╭╮");
      Console.WriteLine("┃╭━━╋┫┃━┫ ╭┫ ╭┫┃━╋┫━━┫┃╭━╮┃╭╮┃╰╯┫┃━┫╭┫┃╱┃┃");
      Console.WriteLine("┃┃╱╱┃┃┃━┫ ┃┃ ┃┃┃━┫┣━━┃┃╰━╯┃╭╮┃╭╮┫┃━┫┃┃╰━╯┃");
      Console.WriteLine("╰╯╱╱╰┻━━┻━╯╰━╯╰━━╯╰━━╯╰━━━┻╯╰┻╯╰┻━━┻╯╰━╮╭╯");
      Console.WriteLine("╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━╯┃");
      Console.WriteLine("╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╰━━╯");
      Console.WriteLine("-----------------------------------------");
      
      Console.WriteLine("Hello! Welcome to Pierre's Bakery!");
      Console.WriteLine("Can I interest you in some pastries? How many Danishes can I put you down for?");
      int danishQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("Would you like any bearclaws? Please enter a quantity!");
      int bearclawQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("Perfect, and finally, how many croissants would you like?");
      int croissantQuantity = int.Parse(Console.ReadLine());

      Pastry pastryOrder = new Pastry(danishQuantity, bearclawQuantity, croissantQuantity);
      Console.WriteLine("Thank you so much! Your pastry order total will be $" + pastryOrder.GetPastryTotal() + ".00");

      Console.WriteLine("Do you like bread? We have great sourdough! How many would you like?");
      int sourdoughQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("Would you like any baguettes? Please enter a quantity!");
      int baguetteQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("We also have fresh loaves of pumpernickle. How many can I add to your order?");
      int pumpernickleQuantity = int.Parse(Console.ReadLine());

      Bread breadOrder = new Bread(sourdoughQuantity, baguetteQuantity, pumpernickleQuantity);
      Console.WriteLine("Thank you so much! Your bread order total will be $" + breadOrder.GetBreadTotal() + ".00");

      int finalTotal = breadOrder.GetBreadTotal() + pastryOrder.GetPastryTotal();
      Console.WriteLine("Your final total will be $" + finalTotal + ".00. Thank you! Have a great day!");
    }
  }
}