namespace IfElseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first nubmer and press enter:");
            float firstNR = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert calculation type by number");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert second nubmer and press enter:");
            float secondNR = float.Parse(Console.ReadLine());
            float result = 0;
            if (choice == 1)
            {
                result = firstNR + secondNR;
                Console.WriteLine(firstNR + " + " + secondNR + " = " + result);
            }
            else if (choice == 2)
            {
                result = firstNR - secondNR;
                Console.WriteLine(firstNR + " - " + secondNR + " = " + result);
            }
            else if (choice == 3)
            {
                result = firstNR * secondNR;
                Console.WriteLine(firstNR + " * " + secondNR + " = " + result);
            }
            else if (choice == 4)
            {
                result = firstNR / secondNR;
                Console.WriteLine(firstNR + " / " + secondNR + " = " + result);
            }
            else
            {
                Console.WriteLine("Wrong type");
            }
        }
    }
}
