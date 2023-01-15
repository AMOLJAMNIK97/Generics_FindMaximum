using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_FindMax
{
    public class String_Max
    {
        public string Find_StringMax(string Firststring, string Secondstring, string Thirdstring)
        {
            if (Firststring.CompareTo(Secondstring) > 0 && Firststring.CompareTo(Thirdstring) > 0 ||
                Firststring.CompareTo(Secondstring) >= 0 && Firststring.CompareTo(Thirdstring) > 0 ||
                Firststring.CompareTo(Secondstring) > 0 && Firststring.CompareTo(Thirdstring) >= 0)
            {
                return Firststring;
            }
            if (Secondstring.CompareTo(Firststring) > 0 && Secondstring.CompareTo(Thirdstring) > 0 ||
                Secondstring.CompareTo(Firststring) >= 0 && Secondstring.CompareTo(Thirdstring) > 0 ||
                Secondstring.CompareTo(Firststring) > 0 && Secondstring.CompareTo(Thirdstring) >= 0)
            {
                return Secondstring;
            }
            if (Thirdstring.CompareTo(Firststring) > 0 && Thirdstring.CompareTo(Secondstring) > 0 ||
                Thirdstring.CompareTo(Firststring) >= 0 && Thirdstring.CompareTo(Secondstring) > 0 ||
                Thirdstring.CompareTo(Firststring) > 0 && Thirdstring.CompareTo(Secondstring) >= 0)
            {
                return Thirdstring;
            }
            return Firststring;
        }
    }
}
