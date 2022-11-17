using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork
{
    internal class Tasks
    {
        public void task3()
        {
            int krastine = 10;
            int krastine2 = 15;
            int izambine = ((krastine^2 + krastine2^2)^1/2);
            Console.WriteLine("Trikampio krastiniu ilgiai yra {0}, {1}, tokio trikampio izambine bus {2} ", krastine, krastine2, izambine);
        }
    }
}
