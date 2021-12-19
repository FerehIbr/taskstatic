using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
   public static class Extension
    {
        public static bool Findword(this string sentence,string part)
        {
            bool res = false;
            int partcount = 0;
            for (int i = 0, f=0; i < sentence.Length; i++)
            {
                if (sentence[i]==part[f])
                {
                    f++;
                    partcount++;
                }
                else
                {
                    f = 0;
                    partcount = 0;
                }
                if (partcount==part.Length)
                {
                    res = true;
                    break;
                }

            }
            return res;
        }
    }
}
