namespace CoinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raadius = 6378160000;
            double umbermoood = 2 * Math.PI * raadius;
            double mundiLaebimood = 2.5;
            double mundidKogus = umbermoood / mundiLaebimood;

            Console.WriteLine("Maa ümbermõõt on " + Math.Round(umbermoood) + " cm.");
            Console.WriteLine("Kahe eurost münti on vaja: " + Math.Round(mundidKogus));
        }
    }
}
