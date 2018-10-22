using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 0; i < 11; i++)
            {
                n = i + n;
                Console.WriteLine(n);
            }
        }
    }
}
