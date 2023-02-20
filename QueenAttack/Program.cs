using System; 
using QueenAttack.Business;

namespace QueenAttack
{
class Program
{
  static void Main()
  {
    Console.WriteLine("Enter your Queen X Coordinate from 1 to 8");
    int queenX = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your Queen Y Coordinate from 1 to 8");
    int queenY = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your Other X Coordinate from 1 to 8");
    int otherX = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your Other Y Coordinate from 1 to 8");
    int otherY = int.Parse(Console.ReadLine());

    Coordinate q = new Coordinate(queenX, queenY);
    Coordinate o = new Coordinate(otherX, otherY);

    Console.WriteLine("The answer is: " + Queen.canQueenHit(q, o));
  }
}
}