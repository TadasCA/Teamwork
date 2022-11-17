using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork
{
    internal class Tasks
    {
        public double task1()
        {
            double Diameter  = 6371;
            double Radius = Diameter / 2;
            double SurfaceArea = 4*Math.PI*Math.Pow(2, Radius);
            return (SurfaceArea);
        }

        public double task2()

        {
            double Diameter = 6371;
            double Radius = Diameter / 2;
            double Volume = 4 / 3 * Math.PI * Math.Pow(3, Radius);
            return (Volume);
        }

        public double task3()
        { 

            int krastine = 10;
            int krastine2 = 15;
            double izambine = ((krastine^2 + krastine2^2)^(1/2));
            return izambine;
        }
        public void task4()
        {
            double SurfaceArea = 1;
            double Volume = 1;
            int izambine = 1;
            Console.WriteLine("**********************************");
            Console.WriteLine("* Viso kintamųjų: 3");
            Console.WriteLine("* SurfaceArea: {0}", SurfaceArea);
            Console.WriteLine("* Volume: {0}", Volume);
            Console.WriteLine("* izambine: {0}", izambine);
            Console.WriteLine("* Suma: " + SurfaceArea + Volume + izambine);
            Console.WriteLine("* Vidurkis: " + (SurfaceArea + Volume + izambine) / 3);
            Console.WriteLine("**********************************");
        }
    }
}
