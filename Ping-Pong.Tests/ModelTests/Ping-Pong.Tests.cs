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

    // [TestMethod]
    // public void Numbers_NumberDivisibleBy5_True()
    // {
    //   PingPong testPingPong = new PingPong();
    //   List<string> expectedResultList = new List<string> {"pong"};
    //   var actualResult =  testPingPong.NumberRange(3);
    //   CollectionAssert.AreEqual(expectedResultList, actualResult);
    // }

    // [TestMethod]
    // public void Numbers_PingAndPongWillFillTwoIndexesInList_True()
    // {
    //   PingPong testPingPong = new PingPong();
    //   List<string> expectedResultList = new List<string> {"ping", "pong"};
    //   var actualResult = testPingPong.NumberRange(5);
    //   CollectionAssert.AreEqual(expectedResultList, actualResult);
    // }
    // [TestMethod]
    // public void Numbers_NumbersDivisibleByThreeAndFivePingPong_True()
    // {
    //   PingPong testPingPong = new PingPong();
    //   List<string> expectedResultList = new List<string> {"PiNg-PoNg"};
    //   var actualResult = testPingPong.NumberRange(15);
    //   CollectionAssert.AreEqual(expectedResultList, actualResult);
    // }
    [TestMethod]
    public void Numbers_PingPongNumberLineGenerates_True()
    {
      PingPong testPingPong = new PingPong();
      List<string> expectedResultList = new List<string> {"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "PiNg-PoNg", "16", "17", "ping", "19", "pong"};
      var actualResult =  testPingPong.NumberRange(20);
      CollectionAssert.AreEqual(expectedResultList, actualResult);
    }
  }
}
