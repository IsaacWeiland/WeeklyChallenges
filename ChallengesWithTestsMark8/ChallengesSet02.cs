using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int valsLength = vals.Length;
            if (valsLength % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            double numOut = numbers.Min() + numbers.Max();
            return numOut;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return 0;
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int evenSum = 0;
            foreach (var even in numbers)
            {
                if (even % 2 == 0)
                {
                    evenSum += even;
                }
            }

            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int isOdd = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (var number in numbers)
            {
                isOdd += number;
            }

            if (isOdd % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int odds = 0;
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    if (i % 2 != 0)
                    {
                        odds++;
                    }
                }  
            }

            return odds;
        }
    }
}
