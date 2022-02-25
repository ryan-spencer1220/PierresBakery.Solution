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
      Console.WriteLine("╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━╮╱╱╱╭╮╱╱╱╱╱╱╱╱╱╱");
      Console.WriteLine("┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╭╮╱╱╱┃╭╮┃╱╱╱┃┃╱╱╱╱╱╱╱╱╱╱");
      Console.WriteLine("┃╰━╯┣┳━━┳━━┳━━┳━━┫┣━━╮┃╰╯╰┳━━┫┃╭┳━━┳━┳╮╱╭╮");
      Console.WriteLine("┃╭━━╋┫┃━┫ ╭┫ ╭┫┃━╋┫━━┫┃╭━╮┃╭╮┃╰╯┫┃━┫╭┫┃╱┃┃");
      Console.WriteLine("┃┃╱╱┃┃┃━┫ ┃┃ ┃┃┃━┫┣━━┃┃╰━╯┃╭╮┃╭╮┫┃━┫┃┃╰━╯┃");
      Console.WriteLine("╰╯╱╱╰┻━━┻━╯╰━╯╰━━╯╰━━╯╰━━━┻╯╰┻╯╰┻━━┻╯╰━╮╭╯");
      Console.WriteLine("╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━╯┃");
      Console.WriteLine("╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╰━━╯");
      Console.WriteLine("-----------------------------------------");
      
      Console.WriteLine("Hello! Welcome to Pierre's Bakery!");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("We offer several types of bread and pastries! Please review our menu below.");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("We have three types of pastries, they're $2.00/each and we have a 3 pastries/$5 special today!");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Danish ($2.00)");
      Console.WriteLine("Bearclaw ($2.00)");
      Console.WriteLine("Croissant ($2.00)");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("We offer three varieties of bread, they're $5.00/each and we have a buy two get one free special today!");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Sourdough ($5.00)");
      Console.WriteLine("Baguette ($5.00)");
      Console.WriteLine("Pumpernickle ($5.00)");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Lets start with our freshly made Danishes. How many Danishes can I put you down for?");
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
      Console.WriteLine("Please review your order!");
      Console.WriteLine("Danishes: " + danishQuantity + " || " + "Sourdough: " + sourdoughQuantity);
      Console.WriteLine("Bearclaws: " + bearclawQuantity + " || " + "Baguettes: " + baguetteQuantity);
      Console.WriteLine("Croissants: " + croissantQuantity + " || " + "Pumpernickle: " + pumpernickleQuantity);
      Console.WriteLine("Your final total will be $" + finalTotal + ".00. Have a great day!");
      Console.WriteLine("Thank you! Please press enter to submit your order!");
      Console.ReadLine();
    }
  }
}

