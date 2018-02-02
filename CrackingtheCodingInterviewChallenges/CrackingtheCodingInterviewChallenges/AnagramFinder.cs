using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingtheCodingInterviewChallenges
{
    public class AnagramFinder
    {
        public int FindDeletions(string str1, string str2)
        {
            var countArray = new int[26];
            var asciiofA = (int)'a';

            var deletionCount = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                var asciival = (int)str1[i];
                ++countArray[asciival - asciiofA];
            }

            for (int i = 0; i < str2.Length; i++)
            {
                var asciival = (int)str2[i];
                --countArray[asciival - asciiofA];
            }

            for (int i = 0; i < countArray.Length; i++)
            {
                deletionCount += Math.Abs(countArray[i]);
            }

            return deletionCount;
        }
        public int FindDeletions1(string str1, string str2)
        {
            var str1Array = str1.ToCharArray();

            var str2Array = str2.ToCharArray();

            var deletionCount = 0;

            for (int i = 0; i < str1Array.Length; i++)
            {
                for (int j = 0; j < str2Array.Length; j++)
                {
                    if (str1Array[i] == str2Array[j])
                    {
                        str1Array[i] = str2Array[j] = '0';
                        break;
                    }
                }
            }

            for (int i = 0; i < str1Array.Length; i++)
            {
                if (str1Array[i] != '0')
                {
                    deletionCount++;
                }
            }

            for (int i = 0; i < str2Array.Length; i++)
            {
                if (str2Array[i] != '0')
                {
                    deletionCount++;
                }
            }

            return deletionCount;
        }
    }
}