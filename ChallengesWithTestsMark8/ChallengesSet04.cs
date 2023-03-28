using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var even = numbers.Where(x => x % 2 == 0).Sum(x => x);
            var odd = numbers.Where(x => x % 2 == 1).Sum(x => x);
            return even - odd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new string[4] { str1, str2, str3, str4 };
            return strings.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new int[4] {number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return ( sideLength1 + sideLength2 > sideLength3 &&
                     sideLength2 + sideLength3 > sideLength1 &&
                     sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double a);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullvar = 0;
            for (var i=0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullvar++;
                }
            }
            return nullvar > objs.Length - nullvar;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = numbers.Where(x => x % 2 == 0);

            if (evens.Count() == 0)
            {
                return 0;
            }
            
            return evens.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
            //throw new NotImplementedException();
        }
    }
}
