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
  }
}