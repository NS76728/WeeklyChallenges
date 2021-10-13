using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            foreach (var x in words)
            {
                if (x != null && words != null)
                {
                    if (ignoreCase == true && x.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                    else if (ignoreCase == false && x == word)
                    {
                        return true;
                    }

                }
            }
            return false;

        }

        public bool IsPrimeNumber(int num)
        {
            if(num<=1)
            {
                return false;
            }
            else if( num == 2)
            {
                return true;
            }
            else if (num == 3)
            {
                return true;
            }
            else if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }
            else return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse().Where(x => str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int preNum = numbers[0];
            int currNum = 1;
            int MaxCon = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == preNum)
                {
                    currNum++;
                }
                if (currNum > MaxCon)
                {
                    MaxCon = currNum;
                }
                if (numbers[i] != preNum)
                {
                    currNum = 1;
                }
                preNum = numbers[i];
            }
            return MaxCon;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n < 0)
            {
                return new double[0];
            }
            List<double> NElement = new List<double>();
            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % n == 0)
                {
                    NElement.Add(elements[i - 1]);
                }
            }
            return NElement.ToArray();
        }
    }
}
