using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTableCSharp
{
    internal class Ex02
    {
        public void Run()
        {
            int a = 2;
            int[] v = new int[6];

            while(a < 6)
            {
                v[a] = 10 * a;
                a += 1;
            }

            int index = 0;
            foreach(int valor in v)
            {
                Console.WriteLine($"v[{index}] = {valor}");
                index++;
            }
        }
    }
}
