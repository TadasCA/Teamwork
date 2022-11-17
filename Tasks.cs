using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork
{
    internal class Tasks
    {
        public void task1()
        {
            double Diameter  = 6371;
            double Radius = Diameter / 2;
            double SurfaceArea = 4*Math.PI*Math.Pow(2, Radius);
            Console.WriteLine(SurfaceArea);
        }

        public void task2()

        {
            double Diameter = 6371;
            double Radius = Diameter / 2;
            double Volume = 4 / 3 * Math.PI * Math.Pow(3, Radius);
            Console.WriteLine(Volume);
        }

        public void task3()
        { 

            int krastine = 10;
            int krastine2 = 15;
            int izambine = ((krastine^2 + krastine2^2)^1/2);
            Console.WriteLine("Trikampio krastiniu ilgiai yra {0}, {1}, tokio trikampio izambine bus {2} ", krastine, krastine2, izambine);
        }
    }
}
