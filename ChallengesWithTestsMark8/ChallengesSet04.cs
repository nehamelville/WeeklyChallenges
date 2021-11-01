using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evens = 0;
            int odds = 0;
            
            if (numbers == null || numbers.Length == 0)
                return 0;
            else
            {
                for(int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i]==0)
                    {
                        return 0;
                    }
                    else if (numbers[i]% 2 == 0)
                    {
                        evens += numbers[i];
                    }
                    else
                    {
                        odds += numbers[i]; ;
                    }
                }
            }   
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = 0;
            if (str1.Length<str2.Length)
            {
                shortestLength = str1.Length;
            }
            else
            {
                shortestLength = str2.Length;
            }
            if (str3.Length < shortestLength)
            {
                shortestLength = str3.Length;
            }
            else if (str4.Length < shortestLength)
                shortestLength = str4.Length;
                           
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = number1;           
            smallestNumber = Math.Min(smallestNumber, number2);
            smallestNumber = Math.Min(smallestNumber, number3);
            smallestNumber = Math.Min(smallestNumber, number4);
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            
            if ((sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength3 + sideLength1 > sideLength2))
                return true;
            else
                return false;

        }

        public bool IsStringANumber(string input)
        {
            decimal n;
            bool isNumeric = decimal.TryParse(input, out n);
            return isNumeric;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int itemCount = 0;
            foreach (var item in objs)
            {
                if (item == null)
                {
                    nullCount++;
                }
                else
                {
                    itemCount++;
                }                      
            }
            if (nullCount > itemCount)
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
          
            double sum = 0;
            double count = 0;
            double odds = 0;
            if (numbers==null||numbers.Length==0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                        count++;
                    }
                    else
                    {
                        odds++;
                    }
                }
                if (odds >= 0 && count==0)
             
                return 0;
            }
            
            return sum /count;
        }

        public int Factorial(int number)
        {
            int fact = 1;
            if(number<0)
            {
                throw new ArgumentOutOfRangeException();
            }
           for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
