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
            Floats_Max floats = new Floats_Max();
            float max = floats.Find_FloatMax(25.1f, 10.5f, 22.9f);
            Console.WriteLine(max);
        }
    }
}