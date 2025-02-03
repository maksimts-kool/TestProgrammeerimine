namespace IfElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Control!");
            int number = 189;

            //Kontroll
            if (number == 189)
            {
                Console.WriteLine("Number is bigger");

                if (number > 190 && number < 200)
                {
                    Console.WriteLine("Number is between 190 to 200");
                }
                else
                {
                    Console.WriteLine("Number is bigger than 200");
                }
            }
            else
            {
                Console.WriteLine("Number is smaller");

            }
        }
    }
}
