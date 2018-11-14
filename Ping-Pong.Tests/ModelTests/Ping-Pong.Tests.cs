using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumberRange;

namespace NumberRange.Tests
{
  [TestClass]
  public class NumberTest
  {
    // [TestMethod]
    // public void Numbers_NumberLineGenerates_True()
    // {
    //   PingPong testPingPong = new PingPong();
    //   List<string> expectedResultList = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"};
    //   var actualResult =  testPingPong.NumberRange(20);
    //   CollectionAssert.AreEqual(expectedResultList, actualResult);
    // }

    // [TestMethod]
    // public void Numbers_NumberDivisibleBy3_True()
    // {
    //   PingPong testPingPong = new PingPong();
    //   List<string> expectedResultList = new List<string> {"ping"};
    //   var actualResult =  testPingPong.NumberRange(3);
    //   CollectionAssert.AreEqual(expectedResultList, actualResult);
    // }

    [TestMethod]
    public void Numbers_NumberDivisibleBy5_True()
    {
      PingPong testPingPong = new PingPong();
      List<string> expectedResultList = new List<string> {"pong"};
      var actualResult =  testPingPong.NumberRange(3);
      CollectionAssert.AreEqual(expectedResultList, actualResult);
    }
  }
}
