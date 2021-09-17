using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool b = false;
            foreach (var x in vals)
            {
                if (x == false)
                {
                   return b = true;
                }
                else { b = false; }

            }
            return b;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            bool isodd = false;
            int sum = 0;
            if (numbers == null)
            {
                return isodd = false;
            }
            foreach(var x in numbers)
            {
                if (x%2!=0)
                {
                    sum = sum + x;

                }
                
            }
            if (sum % 2 != 0)
            {
                isodd = true;
            }

            return isodd;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return new Regex(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])").IsMatch(password);

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor > 0) ? dividend / divisor : 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {

            List<int> numbers = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            int[] numbers1 = new int[numbers.Count];
            for (int j = 0; j < numbers.Count; j++)
            {
                numbers1[j] = numbers[j];
            }
            return numbers1;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
