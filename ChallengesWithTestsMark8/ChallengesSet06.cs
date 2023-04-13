using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null)) { return false; }
            // for ignore case true: this could be cleaned up
            if (ignoreCase)
            {
                foreach (string word2 in words)
                {
                    if (word2.ToLower() == word.ToLower()) { return true; }
                }
            }
            // for ignore case false 
            if (!ignoreCase)
            {
                return words.Contains(word);
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) { return false; } 
            for (var i = 2; i < num; i++)
            {
                if (num % i == 0) { return false; }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            bool isUnique;
            for (var i=0; i<str.Length; i++)
            {
                isUnique = true;
                for (var j=0; j<str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        isUnique = false;
                    }
                }
                if (isUnique == true) { index = i; }
            }
            return index; 
            //throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            bool isCon = true;
            var maxCount = 0;
            int count;
            for (var i = 0; i < numbers.Length; i++)
            {
                count = 1;
                var j = i + 1;
                isCon = true;
                while (isCon && j < numbers.Length)
                {
                    if (numbers[i] != numbers[j])
                    {
                        isCon = false;
                    }
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        j++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            //var elem2 = new double[] { };
            var elem2 = new List<double>() { };
            if (n < 1 || elements == null) return elem2.ToArray();
            for (var i = n-1; i < elements.Count; i+=n) 
            {
                elem2.Add(elements[i]);
            }
            return elem2.ToArray();
            //throw new NotImplementedException();
        }
    }
}
