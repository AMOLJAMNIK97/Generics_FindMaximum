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
            String_Max string_Max = new String_Max();
            string Max = string_Max.Find_StringMax("Apple", "Peach", "Banana");
            Console.WriteLine(Max);
        }
    }
}