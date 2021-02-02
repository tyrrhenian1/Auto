using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Power
    {
        public int Calorie { get; set; }
        public double Weight { get; set; }
        public Power(int calorie, double weight)
        {
            Calorie = calorie;
            Weight = weight;
        }
        public double Product()
        {
            double p = Weight * 10 * Calorie;
            return p;
        }
    }
}
