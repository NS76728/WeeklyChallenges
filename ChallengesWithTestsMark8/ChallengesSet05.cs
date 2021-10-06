using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int result = 0;
            do
            {
                startNumber++;
                result = startNumber;
            }
            while (startNumber % n != 0);
            
            return result;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i=0; i<businesses.Length;i++)
            {
                if(businesses[i].TotalRevenue==0)
                {
                    businesses[i].Name="CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
                return false;
            if(numbers.Length==0)
                return false;
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return sum = 0;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sent = "";

            foreach (string x in words)
            {
                if (x.Trim().Length > 0)
                {
                    sent += x.Trim() + " ";
                }
            }
            if (sent.Length == 0)
            {
                return "";
            }
            sent = sent.Substring(0, sent.Length - 1);
            sent += ".";
            return sent;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var four = new List<double>();
            if(elements==null)
            {
                return four.ToArray();
            }
            for (int i = 3; i < elements.Count; i += 4)
            {
                four.Add(elements[i]);

            }
            return four.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
