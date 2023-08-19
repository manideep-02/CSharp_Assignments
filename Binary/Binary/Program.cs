using System;
using FloatToBinaryConversion;
using AdditionOfBinary;

    /// <summary>
    /// this class contains only main method to take input and perform required operations in other classes and display output
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main method takes input and displays the output by performing operation by calling appropriate methods
        /// </summary>
        static void Main(string[] args)
        {
            //Reading float values
            Console.WriteLine("Enter 1st float value");
            double input_number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd float value");
            double input_number2 = double.Parse(Console.ReadLine());
            
            //Object Created for FLoatToBinary Class
            FloatToBinaryConverter floatToBinary = new FloatToBinaryConverter();
            string binary_1 = floatToBinary.FloatToBinary(input_number1);
            string binary_2 = floatToBinary.FloatToBinary(input_number2);
            
            //Object created for BinaryAddition
            Binary_addition add = new Binary_addition();
            double final_result = add.AddBinary(binary_1, binary_2);
            Console.WriteLine(final_result);
        }
    }