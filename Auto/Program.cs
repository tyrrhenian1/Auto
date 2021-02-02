using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write($"Введите калорийность в 100г продукта: ");
                int calorie = int.Parse(Console.ReadLine());
                Console.Write($"Введите массу продукта в кг: ");
                double weight = double.Parse(Console.ReadLine());
                Power power = new Power(calorie, weight);
                Console.WriteLine($"{power.Product()} калорий");
            }
            catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }
            Console.ReadLine();
        }
    }
}
