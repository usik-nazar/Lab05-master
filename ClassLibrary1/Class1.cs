using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Country;
        public string NameArea;
        public double Square;
        public double Population;
        public int InternalDivision;
        public string Mer;
        public bool River;
        public static void Area() {
            Console.WriteLine("Введіть назву країни: ");
            string sCountry = Console.ReadLine();
            Console.WriteLine("Введiть назву області: ");
            string sNameArea = Console.ReadLine();
            Console.WriteLine("Введiть площу: ");
            string sSquare = Console.ReadLine();
            Console.WriteLine("Введiть кількість населення в тисячах: ");
            string sPopulation = Console.ReadLine();
            Console.WriteLine("Введiть кількість районів: ");
            string sInternalDivision = Console.ReadLine();
            Console.Write("Введіть мера: ");
            string sMer = Console.ReadLine();
            Console.WriteLine("Чи є річка в області? (t - так , n - ні) ");
            ConsoleKeyInfo keyRiver = Console.ReadKey();

            Class1 OurArea = new Class1
            {
                Country = sCountry,
                NameArea = sNameArea,
                Square = double.Parse(sSquare),
                River = keyRiver.Key == ConsoleKey.T,
                InternalDivision = int.Parse(sInternalDivision),
                Population = double.Parse(sPopulation),
                Mer = sMer,
            };

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Країна: " + OurArea.Country);
            Console.WriteLine("Її область: " + OurArea.NameArea);
            Console.WriteLine("Площа: " + OurArea.Square);
            Console.WriteLine("Населення: " + OurArea.Population + "тис.");
            Console.WriteLine("Райони: " + OurArea.InternalDivision);
            Console.WriteLine("Мер: " + OurArea.Mer);
            Console.WriteLine(OurArea.River ? "Є річка?" : "Немає річки");
            Console.ReadKey();

        }
    }
}
