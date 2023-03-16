using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null) { return false; }
            else 
            {
                return !vals.All(x => x); 
                // NOT the array. If a single element is originally false, then not will make at least one element true
                // 2nd x checks the truth of 1st x element.
                // a full list of "true" members will show (false => x) and x becomes false b/c false is not true
                // if a single element became "true" from false, then (true => x) and x becomes true
            }
            //throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var oddCount = 0;
            if (numbers == null) { return false; } 
            else 
            {
                foreach (var number in numbers)
                {
                    if (Math.Abs(number) % 2 == 1) { oddCount += number; }
                }
                return Math.Abs(oddCount) % 2 == 1;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool lower = false;
            bool upper = false;
            bool number = false;
            foreach (char c in password)
            {
                if (Char.IsLower(c)) { lower = true; }
                if (Char.IsUpper(c)) { upper = true; }
                if (Char.IsNumber(c)) { number = true; }
            }
            return (lower && upper && number);
            //throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];            
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) { return 0; }
            else { return dividend / divisor; }
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null) { return 0; }
            else
            {
                return (nums[nums.Length - 1] - nums[0]);
            }
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            for (var i = 0; i < 50; i++)
            {
                odds[i] = 2 * i + 1;
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words== null) { return; }
            else
            {
                for (var i=0; i<words.Length; i++)
                {
                    words[i] = words[i].ToUpper();
                }
            }
            //return words;
            //throw new NotImplementedException();
        }
    }
}

