namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siseta värv");
            string värv = Console.ReadLine();
            if (värv == "red" || värv == "blue" || värv == "green" || värv == "white")
            {
                Console.WriteLine("You chose " + värv);
            }
            else 
            {
                Console.WriteLine("Color not recognised");
            }
        }
    }
}
