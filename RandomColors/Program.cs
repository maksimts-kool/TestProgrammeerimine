using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int valik = random.Next(0, 5);
        switch (valik)
        {
            case 0:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");
                break;

            case 1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
                break;

            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");
                break;

            case 3:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("White");
                break;

            case 4:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Orange");
                break;
        }
        Console.ResetColor();
    }
}
