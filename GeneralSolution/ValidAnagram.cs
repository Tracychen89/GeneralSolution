using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram1(string s, string t)
        {

            Char[] sArray = s.ToArray();
            Array.Sort(sArray);
            s = new string(sArray);

            Char[] tArray = t.ToArray();
            Array.Sort(tArray);
            t = new string(tArray);
            if (s.Length != t.Length)
                return false;
            else
            {

                int i, j;

                for (i = 0; i < s.Length; i++)
                {
                    for (j = 0; j < t.Length; j++)
                    {
                        if (s[i] == t[j])
                        {
                            t = t.Remove(j, 1);
                            break;
                        }
                        else if (j == (t.Length - 1) && s[i] != t[j])
                        {
                            return false;
                        }

                    }

                }

                return true;
            }
        }
    }



}
