using System;
using System.Collections.Generic;

namespace NumberList
{
  public class PingPong
  {
    public List<string> NumberRange(int number)
    {
      List<string> testList = new List<string> {};
      for (int i = 1; i <= number; i++)
      if (i % 3 == 0 && i % 5 == 0)
      {
        string step3 = i.ToString("PiNg-PoNg");
        testList.Add(step3);
      }
      else if (i % 5 == 0)
      {
        string step2 = i.ToString("pong");
        testList.Add(step2);
      }
      else if(i % 3 == 0)
      {
        string step1 = i.ToString("ping");
        testList.Add(step1);
      }
      else
      {
        testList.Add(i.ToString());
      }

      return testList;
    }
  }
}
