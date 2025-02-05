using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Fantaasia kohvik!");
        Console.WriteLine("Palun tee valik numbriga: ");
        Console.WriteLine("1. Väike tass");
        Console.WriteLine("2. Keskmine tass");
        Console.WriteLine("3. Suur tass");

        byte valik = byte.Parse(Console.ReadLine());
        double price = 0;

        switch (valik)
        {
            case 1:
                price += 1.5;
                break;
            case 2:
                price += 2.5;
                break;
            case 3:
                price += 3;
                break;
            default:
                Console.WriteLine("Ei teinud valikut");
                break;
        }
        if (price != 0) 
        {
            Console.WriteLine("Tuleb maksta {0:f2}", price);
            Console.ReadKey();
        }
    }
}
