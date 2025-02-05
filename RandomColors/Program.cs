using System;

class Program
{
    static void Main()
    {
        Color c = (Color)(new Random()).Next(0, 5);
        switch (c)
        {
            case Color.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");
                break;
            case Color.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
                break;
            case Color.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");
                break;
            case Color.White:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("White");
                break;
            case Color.Orange:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Orange");
                break;
        }
        Console.ResetColor();
    }
    public enum Color
    { 
        Red, Green, Blue, White, Orange
    }
}
