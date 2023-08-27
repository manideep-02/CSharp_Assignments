using System;
public class MaxProduct
{
    public void AdjacentCalculation()   //Performing on Adjacent Numbers for maxProduct
    {
        Console.Write("Enter a number: ");
        string numbers = Console.ReadLine();    //Reading numbers

        int maxLength = numbers.Length; //Finding the Length of the Value

        if (maxLength > 3)     //Entered value must be greater than 3
        {
            long maxProduct = 0;    //making "maxProduct" zero
            string maxDigits = "";  //making "maxDigits" null

            for (int i = 0; i <= maxLength - 4; i++)    //Condition is that it takes Adjacent of 4 digits at a time
            {
                string digits = numbers.Substring(i, 4);   //taking 4 digits out of the value from the entered value(numbers)
                long product = CalculateProduct(digits);    //Calling Method

                if (product > maxProduct)   //checking whether product is greater than or not
                {
                    maxProduct = product;   //Assigning that calculated value to maxProduct
                    maxDigits = digits;     //Assigning 4 digits to maxDigits
                }//end of if
            }//end of for loop

            //with help of indexes we are printing individual values all multiplying all the digits to get "maxProduct" value 
            Console.WriteLine($"Max Product: {maxDigits[0]}*{maxDigits[1]}*{maxDigits[2]}*{maxDigits[3]}={maxProduct}");

            //Calculating that 4 digits 
            static long CalculateProduct(string digits)
            {
                long product = 1;
                foreach (char digit in digits)//4 digits will split into individual by char and stores in "digit" 
                {
                    product *= (long)Char.GetNumericValue(digit);//that single digit will converted to long for multiplication process by typecasting
                                                                 //in this way all 4 digits processed and returned as "product"
                }//end of "foreach" Method
                return product; //returning the calculated value
            }//end of CalculateProduct Method
        }//end of if
        else
        {
            Console.WriteLine("Lenth of value should be more than 3 digits.....");
        }
    }

}