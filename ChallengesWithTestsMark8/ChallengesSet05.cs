using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (Math.Abs(startNumber) % n != 0)
            {
                startNumber++;
            }
            return startNumber;
            //return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (var i=0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }
            if (numbers.Length == 1) { return true; }
            for (var i=1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if (numbers == null || numbers.Length == 0) { return sum; }
            for (var i = 1; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i-1]) % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var sentence = "";
            if (words == null || words.Length == 0) return sentence;

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if (sentence.Length == 0) return "";
            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            var fourth = new List<double>();
            for (var i = 3 ; i < elements.Count; i+=4)
            {
                fourth.Add(elements[i]);
            }
            return fourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber) { return true; }
                }
            }
            return false;
            //throw new NotImplementedException();
        }
    }
}
