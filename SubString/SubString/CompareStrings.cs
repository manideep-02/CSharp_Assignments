using System;

namespace SubstringCheck
{
    public class CompareStrings
    {
        public void ReadStrings()//Reading two strings then performing Substring operation
        {
            //Using "ToLower()" method used to convert entered strings to lowercase 
            Console.WriteLine("Enter the first string : ");
            string firstString = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the second string : ");
            string secondString = Console.ReadLine().ToLower();

            int occurrence = 0; 
            int index = firstString.IndexOf(secondString);//To Find the Indexes of Strings

            while (index != -1) //Loops stops when there are no common substrings
            {
                occurrence++;   //Counting Number of Occurrences
                Console.WriteLine($"Found at index: {index}");  //Printing Indexes of Common Strings
                index = firstString.IndexOf(secondString, index + 1);
            }

            if (occurrence > 0) //if there are any occurrences then condition will be true
            {
                Console.WriteLine($"The Second String occurred {occurrence} times in the first string.");
            }
            else
            {
                Console.WriteLine("The second string is not a Substring of the first string.");

            }
        }
    }
}
