using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> multipliers = new List<int> { 2, 3, 4, 5, 6 };
            for (int i = 0; i < 1000000; i++)
            {
                if (multipliers.All(x => NumberLengthIsSix(x * i) && AllDigitsAreDisctinct(x * i) && AllNumbersAreTheSame(x * i, i)))
                {
                    Console.WriteLine("The magic number is " + i);

                    foreach (int multiplier in multipliers)
                    {
                        Console.WriteLine($"If you multiply it by {multiplier}, you get {multiplier *i}.");
                    }
                }
            }
        }
        #region Functions
        static bool NumberLengthIsSix(int number)
        {
            return number.ToString().Length == 6 ? true : false;
        }
        static bool AllNumbersAreTheSame(int resultNumber, int theNumber)
        {
            if (resultNumber.ToString().All(x => theNumber.ToString().Contains(x)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool AllDigitsAreDisctinct(int number)
        {
            return number.ToString().Length == number.ToString().Distinct().Count() ? true : false;
        }
        #endregion
    }
}
