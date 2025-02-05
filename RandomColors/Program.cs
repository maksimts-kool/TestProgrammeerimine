using System;

class Program
{
    static void Main()
    {
       
        
        for (int i=0;i<1000;i++)
        {
            Color c = (Color)(new Random()).Next(0, 5);
            switch (c)
        {
            case Color.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");
                    Console.Beep();
                break;
            case Color.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
                    Console.Beep();
                    break;
            case Color.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");
                    Console.Beep();
                    break;
            case Color.White:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("White");
                    Console.Beep();
                    break;
            case Color.Orange:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Orange");
                    Console.Beep();
                    break;
                    default:
                    break;
        }
        Console.ResetColor();
    }
    }
    public enum Color
    { 
        Red, Green, Blue, White, Orange
    }
}
