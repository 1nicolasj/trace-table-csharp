using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTableCSharp
{
    internal class Ex03
    {
        public void Run()
        {
            int a = 7, b = a - 6;
            int[] v = new int[7];

            while(b < a)
            {
                v[b] = b + a;
                b = b + 2;
            }
            int index = 0;
            foreach (int valor in v)
            {
                Console.WriteLine($"v[{index}] = {valor}");
                index++;
            }
        }
    }
}
