using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms1
{
    class Permutations
    {
        public static void Permute (string str,int start, int end)
        {
            if(start==end)
            {
                Console.WriteLine(str);
            }
            else
            {
                for(int i=start;i<=end;i++)
                {
                    str = Swap(str, start, i);
                    Permute(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }
        }

        public static string Swap(string word,int start, int index)
        {
            char temp;
            char[] charArray = word.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[index];
            charArray[index] = temp;

            string s = new string(charArray);
            return s;
        }
    }
}
