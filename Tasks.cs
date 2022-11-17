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
            double SurfaceArea = (4*Math.PI*Math.Pow(Radius, 2));
            return Math.Round(SurfaceArea, 2);
            
        }

        public double task2()

        {
            double Diameter = 6371;
            double Radius = Diameter / 2;
            double Volume = (4 / 3 * Math.PI * Math.Pow(Radius, 3));
            return Math.Round(Volume, 2);
        }

        public double task3()
        {

            double krastine = 10;
            double krastine2 = 15;
            double izambine = (((int)krastine^2 + (int)krastine2^2)^(1/2));
            return izambine;
        }
        public void task4()
        {
            double SurfaceArea = task1();
            double Volume = task2();
            double izambine = task3();
            double suma = SurfaceArea + Volume + izambine;
            double vidurkis = (SurfaceArea + Volume + izambine) / 3;
            Console.WriteLine("**********************************");
            Console.WriteLine("* Viso kintamųjų: 3");
            Console.WriteLine("* SurfaceArea: {0}", SurfaceArea);
            Console.WriteLine("* Volume: {0}", Volume);
            Console.WriteLine("* izambine: {0}", izambine);
            Console.WriteLine("* Suma: " + suma);
            Console.WriteLine("* Vidurkis: " + vidurkis);
            Console.WriteLine("**********************************");
        }
    }
}
