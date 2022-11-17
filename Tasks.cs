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

        }
        public void task2()
        {
            double Diameter = 6371;
            double Radius = Diameter / 2;
            double Volume = 4/3 * Math.PI * Math.Pow(3, Radius);

        }
    }
}
