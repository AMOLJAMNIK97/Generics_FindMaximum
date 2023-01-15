using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_FindMax
{
    public class Integers_Max
    {
        public int FindMax_Integers(int FirstNum,int SecondNum,int ThirdNum)
        {
            if(FirstNum.CompareTo(SecondNum)>0 && FirstNum.CompareTo(ThirdNum)>0||
                FirstNum.CompareTo(SecondNum)>=0 && FirstNum.CompareTo(ThirdNum)>0 ||
                FirstNum.CompareTo(SecondNum)>0 && FirstNum.CompareTo(ThirdNum)>=0)
            {
                return FirstNum;
            }
            if(SecondNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(ThirdNum) > 0 ||
                SecondNum.CompareTo(FirstNum) >= 0 && SecondNum.CompareTo(ThirdNum) > 0 ||
                SecondNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(ThirdNum) >= 0)
            {
                return SecondNum;
            }
            if(ThirdNum.CompareTo(FirstNum) > 0 && ThirdNum.CompareTo(SecondNum) > 0 ||
                ThirdNum.CompareTo(FirstNum) >= 0 && ThirdNum.CompareTo(SecondNum) > 0 ||
                ThirdNum.CompareTo(FirstNum) > 0 && ThirdNum.CompareTo(SecondNum) >= 0)
            {
                return ThirdNum;
            }
            return 0;
        }
    }
}
