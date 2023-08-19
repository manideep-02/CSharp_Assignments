using System;
using Arithmetic;//Using namespace of Another Project
public class ModifiedProgram
{
    public static void Main(string[] args)
    {
        OriginalProgram.TypeOfOperation = "Addition";    //Changing Original Value
        Console.WriteLine("Changed Value : " + OriginalProgram.TypeOfOperation);
        int result = OriginalProgram.Sum(11, 14);//Calling Sum Method
        Console.WriteLine("Sum of two Numbers : " + result);
    }
}