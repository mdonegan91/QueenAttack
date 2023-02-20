using System;
namespace QueenAttack.Business
{
  public class Queen
  {
    public Queen()
    {

    }

    public static bool canQueenHit(Coordinate queenCoord, Coordinate otherCoord)
    {
      if (queenCoord.x == otherCoord.x)
      {
        return true;
      }
      if (queenCoord.y == otherCoord.y)
      {
        return true;
      }
      if (Math.Abs(queenCoord.x - otherCoord.x) == Math.Abs(queenCoord.y - otherCoord.y))
      {
        return true;
      }
      return false;
    }
  }

  public class Coordinate
  {
    public int x;
    public int y;
    public Coordinate()
    {

    }
    public Coordinate(int inputX, int inputY)
    {
      x = inputX;
      y = inputY;
    }
  }
}