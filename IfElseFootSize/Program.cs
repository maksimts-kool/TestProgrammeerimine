namespace IfElseFootSize
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter shoe size:");
            int input = int.Parse(Console.ReadLine());
            if (input >= 30 && input <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("shoe Size " + input);
            }
            else if (input >= 34 && input <= 38)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("shoe Size " + input);
            }
            else if (input >= 39 && input <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("shoe Size " + input);
            }
            else if (input >= 45 && input <= 48)
            {
                Console.Beep();
                Console.WriteLine("shoe Size " + input + " Alert");
            }
            else
            {
                Console.WriteLine("Invalid shoe size");
            }
        }
    }
}
