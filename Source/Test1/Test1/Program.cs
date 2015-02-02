using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            Console.WriteLine("kick");

            Console.ReadKey();

            Console.WriteLine("Version 1 entstanden");

            Console.ReadKey();

            text.CallHi();

        }
    }
}
