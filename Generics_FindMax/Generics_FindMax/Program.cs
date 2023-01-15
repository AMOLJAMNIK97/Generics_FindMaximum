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
             
            string max1= GenericMaximum<string>.MaxValue("Abhay", "Vikas", "Nana");
            float max2= GenericMaximum<float>.MaxValue(55.2f, 66.4f, 51.0f);
            int max= GenericMaximum<int>.MaxValue(1, 55, 64);
            Console.WriteLine(max);
            Console.WriteLine(max1);
            Console.WriteLine(max2);




        }
    }
}