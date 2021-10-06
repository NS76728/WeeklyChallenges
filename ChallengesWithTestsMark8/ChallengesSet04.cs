using Fare;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (var x in numbers)
            {
                if (x%2==0)
                {
                    total += x;
                }
                else if(x%2!=0)
                {
                    total -= x;
                }

            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            /*
            string result = str1;
            if (result.Length > str2.Length)
            {
                result = str2;
            }
            else if (str2.Length > str3.Length)
            {
                result = str3;
            }
            else if (str3.Length > str4.Length)
            {
                result = str4;
            }
            else
            {
                result = str1;
            }
            int l=result.Length;
            return l;
            */

            return Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str3.Length, str4.Length));

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number4), Math.Min(number2, number3)); 

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool isTriangle = false;
            if(sideLength1+sideLength2>sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
            {
                isTriangle = true;
            }
            
            return isTriangle;
        }

        public bool IsStringANumber(string input)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(input), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            
            bool tf = false;
           
            int result = objs.Count(s => s == null);
            if(result>=(objs.Length/2)+1)
            {
                tf = true;
            }
            else
            {
                tf = false;
            }
            return tf;
        }

        public double AverageEvens(int[] numbers)
        {
            double result;
            if (numbers==null||numbers.Length==0)
            {
                result = 0;
            }
            else
            {
                var evens = numbers.Where(x => x % 2 == 0);
                if (evens.Count()==0)
                {
                    result = 0;
                }
                else
                {
                    result = evens.Average();

                }

            }
            
            return result;
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            if (number == 0) return  1;
            
            int fact = number;

            for (int i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
            
            return fact;

        }

        
    }
}
