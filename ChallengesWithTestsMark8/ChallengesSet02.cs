using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool t=false;
            if (char.IsLetter(c))
            {
                t = true;
            }
            else
            {
                t = false;
            }
            return t;
        }
        //isdigit
        public bool CountOfElementsIsEven(string[] vals)
        {
            bool t = false;
            int l = vals.GetLength(0);
            if (l%2==0)
            {
                t = true;
            }
            else
            {
                t = false;
            }
            return t;
        }

        public bool IsNumberEven(int number)
        {
            bool t = false;
            
            if (number % 2 == 0)
            {
                t = true;
            }
            else
            {
                t = false;
            }
            return t;
        }

        public bool IsNumberOdd(int num)
        {
            bool t = false;

            if (num % 2 == 0)
            {
                t = false;
            }
            else
            {
                t = true;
            }
            return t;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double sum = 0;
            if (numbers == null || numbers.Any()==false)
            {
                sum = 0;
            }
            else
            {
                sum = numbers.Max() + numbers.Min();
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int strLength = 0;
            if(str1.Length>str2.Length)
            {
                strLength = str2.Length;

            }
            else
            {
                strLength = str1.Length;
            }
            return strLength;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                sum = 0;
            }
            else
            sum = numbers.Sum();
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                sum = 0;
            }
            else
            {
                var evens = numbers.Where(x => x % 2 == 0);
                sum = evens.Sum();
            }
               
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            bool t = false;
            if (numbers == null)
            {
                sum = 0;
            }
            else
            {
                sum = numbers.Sum();
            }
            if(sum%2!=0)
            {
                t = true;
            }
            else
            {
                t = false;
            }
            return t;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            if(number<0)
            {
                count = 0;
            }
            else if(number%2!=0)
            {
                count = (number - 1)/2;
            }
            else
            {
                count = number / 2;
            }
            return count;
        }
    }
}
