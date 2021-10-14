using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals==null||vals.Length==0)
            {
                return false;
            }
            foreach (var item in vals)
            {
                if(item==false)
                {
                    return true;
                }
            }
            return false; ;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            foreach (var item in numbers)
            {
                if (item%2!=0)
                {
                    sum += item;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password==null||password=="")
            {
                return false;
            }
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                return true;
            }
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char letter =Convert.ToChar (val.Substring(0, 1));
            return letter;

        }

        public char GetLastLetterOfString(string val)
        {
            int strLength = val.Length;
            char letter = Convert.ToChar(val.Substring(strLength-1,1));

            return letter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            else
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int first = nums[0];
            int last = nums[nums.Length - 1];
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            int[] array = new int[50];
            int j=0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    array[j] = i;
                    j++;
                   
                }

            }
            return array;
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
