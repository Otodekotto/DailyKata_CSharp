using System;
using System.Diagnostics.Tracing;
using System.Numerics;

namespace DailyKata
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        #region Pascal Case
        static void PascalCase()
        {
            string sentence = "“The qUick!  bRoWn fox    jumped, OVER the    lazy. dog”";
            var stringArray = sentence
                .ToLower()
                .Replace("“", "")
                .Replace("”", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("!", "")
                .Replace("?", "")
                .Replace(";", "")
                .Replace(":", "")
                .Split(" ");

            Console.Write("“");

            foreach (var word in stringArray)
            {
                var character = word.ToCharArray();

                for (int i = 0; i < character.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(character[i].ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write(character[i]);
                    }
                }
            }
            Console.WriteLine("”");
        }
        #endregion

        #region Simplifying Fractions
        //Simplify("4/6");
        //Simplify("10/11");
        //Simplify("100/400");
        //Simplify("8/4");

        static void Simplify(string text)
        {
            var splitedText = text.Split("/");
            int[] intSplitedtext = new int[2];
            int[] newText = new int[2];

            for(int i = 0; i < splitedText.Length; i++)
            {
                intSplitedtext[i] = int.Parse(splitedText[i]);
            }

            var greatestCommonFactor = FindGreatestCommonFactor(intSplitedtext[0], intSplitedtext[1]);

            newText[0] = intSplitedtext[0]/ greatestCommonFactor;
            newText[1] = intSplitedtext[1] / greatestCommonFactor;
            if (newText[1] == 1)
                Console.WriteLine(newText[0]);
            else
                Console.WriteLine(newText[0] + "/" + newText[1]);
        }

        static int FindGreatestCommonFactor(int number , int number2)
        {
            List<int> number1factor = new List<int>();
            List<int> number2factor = new List<int>();
            List<int> CommonFactor = new List<int>();
            int numberCounter = number;

            for (int i = 1 ; i < number+1; i++)
            {
                if (number % i == 0)
                {
                    number1factor.Add(i);
                }
            }

            for (int i = 1; i < number2+1; i++)
            {
                if (number2 % i == 0)
                {
                    number2factor.Add(i);
                }
            }

            CommonFactor.AddRange(number1factor.FindAll(x => number2factor.Contains(x)));

            return CommonFactor.Last();
        }
        #endregion

        #region Reducto Multiplication
        public static int SumDigProd(params int[] value)
        {
            var sum = value.Sum();
            


            while (sum.ToString().Length != 1)
            {
                var newSum = 1;
                List<int> listOfInts = new List<int>();
                while (sum > 0)
                {
                    listOfInts.Add(sum % 10);
                    sum = sum / 10;
                }
                for(int i = 0; i<listOfInts.Count; i++)
                {
                    newSum *= listOfInts[i];
                }
                sum = newSum;
            }

            return sum;            
        }
        #endregion
    }
}