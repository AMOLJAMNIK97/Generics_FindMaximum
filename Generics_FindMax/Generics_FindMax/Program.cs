using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Integers_Max integers = new Integers_Max();
            int max=integers.FindMax_Integers(25, 35, 48);
            Console.WriteLine(max);
        }
    }
}