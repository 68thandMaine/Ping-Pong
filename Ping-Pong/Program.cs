using System;
using System.Collections.Generic;

namespace NumberRange
{
  public class Program
  {
    public static void Main()
    {
      //This is where the number list should be. It should use the Enumerable.Range method to generate a range. Enumerable.Range(takes the value of the first integer which will be hard coded to 1, takes the number of sequential integers to generate which will be hard coded to a user input)
      Console.WriteLine("Enter a number to create a range");
      int userInput = Console.ReadLine();
      IEnumerable<int> range = Enumerable.Range(1, userInput);
      foreach (int num in range)
      {
        Console.WriteLine(num);
      }
    }
  }
}
