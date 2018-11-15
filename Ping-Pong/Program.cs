using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberList
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Enter a number to create a range");
      string userInputString = Console.ReadLine();
      int userInputInt = int.Parse(userInputString);
      Console.WriteLine(" ");
      PingPong myPingPong = new PingPong();
      List<string> pingpong = myPingPong.NumberRange(userInputInt);
      Console.WriteLine(pingpong);



      }
    }
  }
