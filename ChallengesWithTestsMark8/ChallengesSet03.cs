using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool isFalse = false;
            foreach (var hasFalse in vals)
            {
                if (!hasFalse)
                {
                    isFalse = true;
                }
            }

            return isFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sumOdds = 0;
            foreach (var odd in numbers)
            {
                if (odd % 2 != 0)
                {
                    sumOdds += odd;
                }
            }

            if (sumOdds % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            foreach (var character in password)
            {
                if (char.IsUpper(character))
                {
                    hasUpper = true;
                }
                if (char.IsLower(character))
                {
                    hasLower = true;
                }
                if (char.IsNumber(character))
                {
                    hasNumber = true;
                }
            }

            if (hasLower && hasUpper && hasNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsBelowHundred = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsBelowHundred.Add(i);
                }
            }
            int[] oddsBelowHundredArray = oddsBelowHundred.ToArray();
            return oddsBelowHundredArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                     words[i] = words[i].ToUpper();   
                
            }
        }
    }
}
