using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length%2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number%2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return Math.Abs(num)%2 == 1 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers == null || !numbers.Any()) ? 0 : numbers.Max() + numbers.Min();
            //return numbers.Any()!=true ? 0 : (numbers.Max() + numbers.Min());
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                var even = 0;
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        even += num;
                    }
                }
                return even;
            }
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) { return false; }
            else
            {
                return (Math.Abs(numbers.Sum()) % 2 == 1) ? true : false;
            }
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number>0) ? number/2 : 0;
        }
    }
}
