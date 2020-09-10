using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            return (Char.IsLetter(c));
            

            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;

        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
            
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
            
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count<double>() == 0)
            {
                return 0;
            }
            double minimumNum = numbers.Min();
            double maximumNum = numbers.Max();
            double sum = minimumNum + maximumNum;
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            
            if(numbers == null)
            {
                return 0;
            }
            var answ = numbers.Sum();
            return answ;
        }

        public int SumEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null) { return 0; }
            var num = new List<int>();
            int listSum = 0;
            foreach(var number in numbers)
            {
                if(number % 2 == 0)
                {
                    num.Add(number);
                    
                }listSum = num.Sum();
            }return listSum;

            //var num = numbers.Sum();
            //if (num % 2 == 0)
            //{
            //    return numbers.Sum();
            //}
            // return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
          
            if(numbers == null) { return false; }
            int num = numbers.Sum();

            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            
            if(number < 0)
            {
                return 0;
            }return number / 2;
        }
    }
}
