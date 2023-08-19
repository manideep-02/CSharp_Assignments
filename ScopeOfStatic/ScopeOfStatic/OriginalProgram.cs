using System;

namespace Arithmetic
{
    public class OriginalProgram
    {
        public static string TypeOfOperation = "Calculation";//Static Variable Original Value
        public static int Sum(int num1, int num2)//Sum Method will perform addition
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Original Value : " + TypeOfOperation);
            int result = Sum(10, 25); // Calling Sum Method 
            Console.WriteLine("Sum of two Numbers : " + result);
        }
    }
}