using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 10f;
            float b = 38f;
            float c = (31 - 5 * a)/b;
            Console.WriteLine(c);
            Console.ReadKey();  
        }
    }
}
