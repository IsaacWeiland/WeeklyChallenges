using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int finalCalc = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    finalCalc += number;
                }
                else
                {
                    finalCalc -= number;
                }
            }

            return finalCalc;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestString = 0;
            if (str1.Length < str2.Length && str1.Length < str3.Length && str1.Length < str4.Length)
            {
                shortestString = str1.Length;
            }
            else if (str2.Length < str1.Length && str2.Length < str3.Length && str2.Length < str4.Length)
            {
                shortestString = str2.Length;
            }
            else if (str3.Length < str2.Length && str3.Length < str2.Length && str3.Length < str4.Length)
            {
                shortestString = str3.Length;
            }
            else if (str4.Length < str1.Length || str4.Length < str2.Length || str4.Length < str3.Length)
            {
                shortestString = str4.Length;
            }
            else
            {
                shortestString = str1.Length;
            }
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 < number2 && number1 < number3 && number1 < number4)
            {
                return number1;
            }
            else if (number2 < number1 &&  number2 < number3 && number2 < number4)
            {
                return number2;
            }
            else if (number3 < number1 && number3 < number2 && number3 < number4)
            {
                return number3;
            }
            else if (number4 < number1 && number4 < number2 && number4 < number3)
            {
                return number4;
            }
            else if (number1 == number2)
            {
                return number1;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool isTriangle = sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 &&
                              sideLength2 + sideLength3 > sideLength1;
            return isTriangle;
        }

        public bool IsStringANumber(string input)
        {
            bool isString = double.TryParse(input, out double finished);
            return isString;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int arrayNulls = 0;
            foreach (var isNull in objs)
            {
                if (isNull == null)
                {
                    arrayNulls++;
                }
            }

            if (arrayNulls > objs.Length/2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double evenAdd = 0;
            double evenTotal = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenAdd += number;
                    evenTotal++;
                }
            }

            if (evenTotal == 0)
            {
                return 0;
            }
            return evenAdd / evenTotal;
        }

        public int Factorial(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int factorial = 1;
            for(int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
