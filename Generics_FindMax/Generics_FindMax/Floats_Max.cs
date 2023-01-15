using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_FindMax
{
    public class Floats_Max
    {
        public float Find_FloatMax(float First,float Second,float Third)
        {
            if(First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0 ||
                First.CompareTo(Second) >= 0 && First.CompareTo(Third) > 0 ||
                First.CompareTo(Second) > 0 && First.CompareTo(Third) >= 0)
            {
                return First;
            }
            if(Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0 ||
                Second.CompareTo(First) >= 0 && Second.CompareTo(Third) > 0 ||
                Second.CompareTo(First) > 0 && Second.CompareTo(Third) >= 0)
            {
                return Second;
            }
            if(Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0 ||
                Third.CompareTo(First) >= 0 && Third.CompareTo(Second) > 0 ||
                Third.CompareTo(First) > 0 && Third.CompareTo(Second) >= 0)
            {
                return Third;
            }
            return 0;
        }
    }
}
