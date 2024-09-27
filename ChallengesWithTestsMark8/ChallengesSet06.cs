using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            try
            {
                if (words.Contains(null))
                {
                    return false;
                }
                words = words.ToList();
                if (ignoreCase)
                {
                    foreach (var singleWord in words)
                    {
                        string checkWord = singleWord.ToLower();
                        if (checkWord.Equals(word.ToLower()))
                        {

                            return true;
                        }
                    }
                }
                else
                {
                    if (words.Contains(word))
                    {

                        return true;
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                return false;
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num > 1)
            {
                return Enumerable.Range(1, num).Where(x => num % x == 0).SequenceEqual(new[] { 1, num });
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int returnIndex = -1;
            if (str.Length > 1)
            {
                var charArr = str.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    int count = str.Count(f => f == charArr[i]);
                    if (count == 1)
                    {
                        returnIndex = i;
                    }

                }
            }
            else if (str == "")
            {
                returnIndex = -1;
            }
            else
            {
                returnIndex = 0;
            }

            return returnIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int? preIndex = null;
            var count = 0;
            var prevMax = 0;
            foreach (var num in numbers)
            {
                if (num == preIndex)
                {
                    if (count < 2)
                    {
                        count = 2;
                    }
                    else
                    {
                        count++;    
                    }
                }
                else
                {
                    count = 0;
                }
                if (count >= prevMax)
                {
                    prevMax = count;
                }
                preIndex = num;
            }

            return prevMax;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var returnList = new List<double>();
            if (elements == null || n < 0)
            {
                return returnList.ToArray();
            }
            foreach (var element in elements)
            {
                if (element % n == 0)
                {
                    returnList.Add(element);
                }
            }

            return returnList.ToArray();
        }
    }
}
