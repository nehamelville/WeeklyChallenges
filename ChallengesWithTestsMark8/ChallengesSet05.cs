using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            int number = startNumber + 1;
            bool flag = true;
            while (flag)
            {
                if (number % n == 0)
                    flag = false;
                else
                    number++;
            }
            return number;
           
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i=0;i<businesses.Length;i++)
            {
                Business currentBusiness = businesses[i];
                if (currentBusiness.TotalRevenue == 0d)
                {
                    currentBusiness.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool ascending = true;
            if (numbers == null || numbers.Length == 0)
                 return false;
            for(int i=0;i<numbers.Length-1;i++)
            {
                ascending = numbers[i] <= numbers[i + 1];
                if (!ascending)
                    return false;
            }
            return ascending ;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if(numbers==null ||numbers.Length==0)
            {
                return sum;
            }
            for(int i=0;i<numbers.Length-1;i++)
            {
                if(numbers[i]%2==0)
                {
                    sum += numbers[i + 1];
                }           

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence ="";
            string word="";
            if (words == null || words.Length == 0)
                return sentence;
            for(int i=0;i<words.Length;i++)
            {
                word = words[i].Trim();
                if (word.Length>0)
                {
                    sentence += word + " ";
                }         
            }
            if (word != "")
                return sentence.Trim() + ".";
            else
                return sentence.Trim();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null ||elements.Count<4)
                return new double[] {};
            List<double> fourthElementList = new List<double>();
            for (int i =3,j=0; i < elements.Count; i+=4,j++)
            {
                fourthElementList.Add(elements[i]);
            }
            return fourthElementList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
          
            if (nums == null || nums.Length == 0)
                return false;

            //O(n) solution using Dictionary/HashSet
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(targetNumber - nums[i]))
                {
                    return true;
                } else
                {
                    set.Add(nums[i]);
                }
            }
            return false;

            ////O(n^2) Brute Force Solution
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for(int j=i+1;j<nums.Length;j++)
            //    {
            //        if(nums[i]+nums[j]==targetNumber)
            //            return true;
            //    }
               
            //}
            //return false;
           
        }
    }
}
