using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringExtentionMethod
{
    public static class Extensions
    {
        public static StringBuilder SubString(this StringBuilder str, int index, int lenght)
        {
            StringBuilder strBuilder = new StringBuilder();
            string s = str.ToString();
            s = s.Substring(index, lenght);
            return strBuilder.Append(s);
        }
    }
}
