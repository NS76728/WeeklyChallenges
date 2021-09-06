using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double total = minuend - subtrahend;
            return total;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int lessNum = 0;
           if (number1 < number2)
            {
                lessNum = number1;
            }
           else
            {
                lessNum = number2;
            }
            return lessNum;

        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            string s = "";

            if (nameOfPerson == "")
            {
                s = "Hello!";
            }
            else
            { 
               s = $"Hello, {nameOfPerson}!";
            }
            return s;

        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
