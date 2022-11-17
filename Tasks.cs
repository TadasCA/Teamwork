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
            int Diameter  = 6371;
            int Radius = Diameter / 2;
            double SurfaceArea = (4*Math.PI*Math.Pow(2, Radius));
            return SurfaceArea;
        }

        public double task2()

        {
            int Diameter = 6371;
            int Radius = Diameter / 2;
            double Volume = (4 / 3 * Math.PI * Math.Pow(3, Radius));
            return Volume;
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
            double SurfaceArea = task1();
            double Volume = task2();
            double izambine = task3();
            Console.WriteLine("**********************************");
            Console.WriteLine("* Viso kintamųjų: 3");
            Console.WriteLine("* SurfaceArea: ", SurfaceArea);
            Console.WriteLine("* Volume: ", Volume);
            Console.WriteLine("* izambine: {0}", izambine);
            Console.WriteLine("* Suma: " + SurfaceArea + Volume + izambine);
            Console.WriteLine("* Vidurkis: " + (SurfaceArea + Volume + izambine) / 3);
            Console.WriteLine("**********************************");
        }
    }
}
