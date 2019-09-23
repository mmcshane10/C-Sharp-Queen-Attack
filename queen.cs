using System;

class Queen
{
  static void Main()
  {
    Console.WriteLine("What is the X coordinate of your Queen? [choose a number between 1-8]");
    int queenXInt = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the Y coordinate of your Queen? [choose a letter between A-H]");
    string queenYPosition = Console.ReadLine();

    Console.WriteLine("What is the X coordinate of your Enemy's piece? [choose a number between 1-8]");
    int enemyXInt = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the Y coordinate of your Enemy's piece? [choose a letter between A-H]");
    string enemyYPosition = Console.ReadLine();
    
    string[] yCoord = {"A", "B", "C", "D", "E", "F", "G", "H"};
    int queenYInt = Array.IndexOf(yCoord, queenYPosition) + 1;
    int enemyYInt = Array.IndexOf(yCoord, enemyYPosition) + 1;
    
    if (queenXInt == enemyXInt || queenYPosition == enemyYPosition || Math.Abs((queenYInt - enemyYInt) / (queenXInt - enemyXInt)) == 1)
    {
      Console.WriteLine("You Can Attack!");
    }
    else {
      Console.WriteLine("You CANNOT Attack!");
    }
  }
}