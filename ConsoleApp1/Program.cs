// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            Console.WriteLine("Odaberi:");
            Console.WriteLine("e: EUR -> HRK");
            Console.WriteLine("h: HRK -> EUR");
            Console.WriteLine("Za izlazak upiši exit.");

            while (exit == false)
            {
                switch (Console.ReadLine())
                {
                    case "e":
                        Console.Write("Unesi eure: ");
                        double eur = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("HRK: " + eur * 7.55);
                        break;
                    case "h":
                        Console.Write("Unesi kune: ");
                        double kune = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("HRK: " + kune / 7.55);
                        break;
                    case "exit":
                        exit = true;
                        break;
                }

            }
            
        }
    }
}
