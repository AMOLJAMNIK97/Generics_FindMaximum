using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_FindMax
{
    internal class GenericMaximum<T> where T : IComparable
    {
        public T FirstValue,SecondValue,ThirdValue;
        public GenericMaximum(T FirstValue, T SecondValue,T ThirdValue)
        {
            this.FirstValue = FirstValue;
            this.SecondValue = SecondValue;
            this.ThirdValue = ThirdValue;

        }
        public static T MaxValue(T FirstValue, T SecondValue,T ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
                FirstValue.CompareTo(SecondValue) >= 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
                FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) >= 0)
            {
                return FirstValue;
            }
            if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValue) >= 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValue) >= 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) >= 0)
            {
                return ThirdValue;
            }
            return default;

        }
        public T MaxMethod()
        {
            T max = GenericMaximum<T>.MaxValue(this.FirstValue, this.SecondValue, this.ThirdValue);
            return max;
        }
        public void Display()
        {
            Console.WriteLine(FirstValue  + " "+ SecondValue +" "+ ThirdValue );
        }
        
    }
}
