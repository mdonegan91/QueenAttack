using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Business;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTests
  {
    [TestMethod]
    public void QueenConstructor_CreatesInstanceOfQueen_Queen()
    {
      Queen newQueen = new Queen();
      Assert.AreEqual(typeof(Queen), newQueen.GetType());
    }

    [TestMethod]
    public void CoordinateConstructor_CreateInstanceOfCoordinate_Coordinate()
    {
      Coordinate newCoordinate = new Coordinate();
      Assert.AreEqual(typeof(Coordinate), newCoordinate.GetType());
    }

    [TestMethod]
    public void CoordinateConstructor_CreateInstanceOfCoordinateWithTwoInts_Coordinate()
    {
      Coordinate newCoordinate = new Coordinate(5,5);
      Assert.AreEqual(5, newCoordinate.x);
      Assert.AreEqual(5, newCoordinate.y);
    }

    [TestMethod]
    public void GetResult_DetermineQueenHit_Bool()
    {
      Coordinate coord1 = new Coordinate(1,2);
      Coordinate coord2 = new Coordinate(1,7);
      Assert.AreEqual(true, Queen.canQueenHit(coord1, coord2));
    }
  }
}