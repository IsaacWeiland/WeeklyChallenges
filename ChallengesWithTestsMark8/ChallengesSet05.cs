using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber += 1;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var name in businesses)
            {
                if (name.TotalRevenue == 0)
                {
                    name.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool isAscending = true;
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            var ascending = numbers.OrderBy(x => x).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != ascending[i])
                {
                    isAscending = false;
                }
            }


            return isAscending;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return sum;
            }
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    
                    sum += numbers[i + 1];    
                    
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var joinString = new List<string>();
            string sentence = "";
            if (words == null)
            {
                return sentence;
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim() != "")
                {
                    joinString.Add(words[i].Replace(" ",""));
                }
                
            }

            sentence = string.Join(" ", joinString);
            if (sentence.Trim() == "")
            {
                return sentence.Trim();
            }
            else
            {
                return sentence.Trim()+".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var returnElements = new List<double>();
            if (elements == null)
            {
                return returnElements.ToArray();
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 4 == 0)
                {
                    returnElements.Add(elements[i]);
                }
            }

            return returnElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = nums.Length-1; i >= 0; i--)
            {
                for (int j = nums.Length-1; j >= 0; j--)
                {
                    
                    if (nums[i]+nums[j] == targetNumber && i != j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
