namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 7);

            Console.WriteLine(randomNumber);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("number on 1");
                    break;
                case 2:
                    Console.WriteLine("number on 2");
                    break;
                case 3:
                    Console.WriteLine("number on 3");
                    break;
                case 4:
                    Console.WriteLine("number on 4");
                    break;
                case 5:
                    Console.WriteLine("number on 5");
                    break;
                case 6:
                    Console.WriteLine("number on 6");
                    break;
                default:
                    Console.WriteLine("Viga number");
                    break;
            }
        }
    }
}
