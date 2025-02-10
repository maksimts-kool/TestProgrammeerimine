namespace SwitchCoinDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much coins:");
            int coins = int.Parse(Console.ReadLine());
            int five = coins / 50;
            coins -= five * 50;
            int two = coins / 20;
            coins -= two * 20;
            int ten = coins / 10;
            coins -= ten * 10;
            int five0 = coins / 5;
            coins -= five0 * 5;
            int two0 = coins / 2;
            coins -= two0 * 2;
            int one = coins;
            Console.WriteLine("You have: ");
            if (five > 0)
            {
                Console.WriteLine($"{five} - 50 cent coins");
            }
            else if (two > 0)
            {
                Console.WriteLine($"{two} - 20 cent coins");
            }
            else if (ten > 0)
            {
                Console.WriteLine($"{ten} - 10 cent coins");
            }
            else if (five0 > 0)
            {
                Console.WriteLine($"{five0} - 5 cent coins");
            }
            else if (two0 > 0)
            {
                Console.WriteLine($"{two0} - 2 cent coins");
            }
            else if (one > 0)
            {
                Console.WriteLine($"{one} - 1 cent coins");
            }
        }
    }
}
