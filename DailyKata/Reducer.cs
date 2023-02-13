using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyKata
{
    public class Reducer
    {
        public static int SumDigProd(params int[] value)
        {
            var sum = value.Sum();

            while (sum.ToString().Length != 1)
            {
                var newSum = 1;
                List<int> listOfDigit = new List<int>();
                while (sum > 0)
                {
                    listOfDigit.Add(sum % 10);
                    sum = sum / 10;
                }
                foreach(int digit in listOfDigit)
                {
                    newSum *= digit;
                }
                sum = newSum;
            }
            return sum;
        }
    }
}
