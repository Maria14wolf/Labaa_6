using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string[] data = Console.ReadLine().Trim().Split();
            int A = Int32.Parse(data[0]);
            int B = Int32.Parse(data[1]);
            Console.WriteLine(A + B);
            Console.ReadKey();
        }
    }
}
