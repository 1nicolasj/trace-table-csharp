using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTableCSharp
{
    internal class Ex01
    {
        public void Run()
        {
            int a = 10, b = 20, c = (a + b) / 2;
            c = c - 40;
            int[] v = new int[4];

            for(int i = 0; i < v.Length; i++)
            {
                if (i == 3)
                {
                    v[i] = a + b + c;
                }

                Console.WriteLine($"v[{i}] = {v[i]}");
                //condicao v ou f
                if (v[i] == 5)
                {
                    Console.Write("Verdadeiro");
                }
                else
                {
                    Console.WriteLine("Falso");
                }
            }
        }
    }
}
