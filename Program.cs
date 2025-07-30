/*
"Divisible by 2 or 3"

Given two integers, write a method that returns their multiplication if they are both evenly divisible by 2 or 3,
otherwise returns their sum.

Expected input and output
    DivisibleBy2Or3(15, 30) → 450 
    DivisibleBy2Or3(2, 90) → 180 
    DivisibleBy2Or3(7, 12) → 19 
*/

namespace ChallengeLab_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 30;
            Console.WriteLine($"DivisibleBy2or3({num1}, {num2}) -> "+
            DivisibleBy2or3(num1, num2));

            num1 = 2;
            num2 = 90;
            Console.WriteLine($"DivisibleBy2or3({num1}, {num2}) -> " +
            DivisibleBy2or3(num1, num2));

            num1 = 7;
            num2 = 12;
            Console.WriteLine($"DivisibleBy2or3({num1}, {num2}) -> " +
            DivisibleBy2or3(num1, num2));
        }

        static int DivisibleBy2or3(int num1, int num2)
        {
            // If (num1 AND num2 are divisible by 2) OR (num1 AND num2 are divisible by 3)
            if ((num1 % 2 == 0 && num2 % 2 == 0) || (num1 % 3 == 0 && num2 % 3 == 0))
                return num1 * num2; // Return product
            else
                return num1 + num2; // Return sum
        }
    }
}
