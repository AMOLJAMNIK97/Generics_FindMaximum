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
            GenericMethod generic = new GenericMethod();
            int Max = generic.MaxValue<int>(22, 35, 12);
            float floatvalue = generic.MaxValue<float>(85.2f, 10.55f, 66.4f);
            string stringMax = generic.MaxValue<string>("sanjay", "Salman", "Rahul");
            Console.WriteLine(Max +" "+ floatvalue +" "+ stringMax );
        }
    }
}