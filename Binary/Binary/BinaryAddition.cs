namespace AdditionOfBinary
{
    /// <summary>
    /// This class contains various methods for performing binary addition
    /// </summary>
    public class Binary_addition
    {
        /// <summary>
        /// this method will call check_binary method to get a result in which both binary numbers have same length
        /// </summary>
        /// <param name="binary1"></param>
        /// <param name="binary2"></param>
        /// <returns></returns>
        public double AddBinary(string binary1, string binary2)
        {
            double final_result = Check_binary(ref binary1, ref binary2);
            return final_result;
        }//end of AddBinary Method

        /// <summary>
        /// this method make sure that both binary numbers will have same length by adding appropriate zeroes at ending or strarting
        /// </summary>
        /// <param name="binary1"></param>
        /// <param name="binary2"></param>
        /// <returns></returns>
        public double Check_binary(ref string binary1, ref string binary2)
        {
            int len1 = binary1.Length;
            int len2 = binary2.Length;
            int i = 0;
            int l = 0;
            int j = len1 - 1;
            int k = len2 - 1;
            string str1= String.Empty;
            string str2 = String.Empty;
            string str3 = String.Empty;
            string str4 = String.Empty;
            int str1len = 0;
            int str2len = 0;
            int str3len = 0;
            int str4len = 0;
            while (binary1[i] != '.')
            {
                str1 = str1 + binary1[i];
                str1len += 1;
                i += 1;
            }
            while (binary2[l] != '.')
            {
                str2 = str2 + binary2[l];
                l += 1;
                str2len += 1;
            }
            while (binary1[j] != '.')
            {
                str3 = str3 + binary1[j];
                j -= 1;
                str3len += 1;
            }

            while (binary2[k] != '.')
            {
                str4 = str4 + binary2[k];
                k -= 1;
                str4len += 1;
            }
            if (str1.Length > str2.Length)
            {
                for (int i1 = 0; i1 < str1len - str2len; i1++)
                {
                    str2 = '0' + str2;
                }
            }
            else
            {
                for (int i1 = 0; i1 < str2len - str1len; i1++)
                {
                    str1 = '0' + str1;
                }
            }
            if (str3.Length > str4.Length)
            {
                for (int i1 = 0; i1 < str3len - str4len; i1++)
                {
                    str4 = str4 + '0';
                }
            }
            else
            {
                for (int i1 = 0; i1 < str4len - str3len; i1++)
                {
                    str3 = str3 + '0';
                }
            }
            binary1 = str1 + '.' + str3;
            binary2 = str2 + '.' + str4;
            double final_result = add_binary(str1, str2, str3, str4);
            return final_result;
        }//end of CheckBinary Method

        /// <summary>
        /// this method will add the 2 binary numbers by splitting the binary numbers into int and decimal values
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        /// <param name="str4"></param>
        /// <returns></returns>
        public double add_binary(string str1, string str2, string str3, string str4)
        {
            int carry = 0;
            string res1 = "";
            //Add decimal points of the binary numbers
            for (int i = str3.Length - 1; i >= 0; i--)
            {
                if (carry == 0)
                {
                    if (str3[i] == '0' && str4[i] == '0')
                    {
                        res1 = "0" + res1;
                        continue;
                    }
                    else if ((str3[i] == '1' && str4[i] == '0') || (str3[i] == '0' && str4[i] == '1'))
                    {
                        res1 = "1" + res1;
                        carry = 0;
                        continue;
                    }
                    else if ((str3[i] == '1' && str4[i] == '1'))
                    {
                        res1 = "0" + res1;
                        carry = 1;
                        continue;
                    }
                }
                else if (carry == 1)
                {
                    if (str3[i] == '0' && str4[i] == '0')
                    {
                        res1 = "1" + res1;
                        carry = 0;
                        continue;
                    }
                    else if ((str3[i] == '1' && str4[i] == '1'))
                    {
                        res1 = "1" + res1;
                        carry = 1;
                        continue;
                    }
                    else if ((str3[i] == '1' && str4[i] == '0') || (str3[i] == '0' && str4[i] == '1'))
                    {
                        res1 = "0" + res1;
                        carry = 1;
                        continue;
                    }
                }
            }
            string res2 = "";
            //Add  int values of the binary numbers
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                if (carry == 0)
                {
                    if (str1[i] == '0' && str2[i] == '0')
                    {
                        res2 = "0" + res2;
                        continue;
                    }
                    else if ((str1[i] == '1' && str2[i] == '1'))
                    {
                        res2 = "0" + res2;
                        carry = 1;
                        continue;
                    }
                    else if ((str1[i] == '1' && str2[i] == '0') || (str1[i] == '0' && str2[i] == '1'))
                    {
                        res2 = "1" + res2;
                        carry = 0;
                        continue;
                    }
                }
                else if (carry == 1)
                {
                    if (str1[i] == '0' && str2[i] == '0')
                    {
                        res2 = "1" + res2;
                        carry = 0;
                        continue;
                    }
                    else if ((str1[i] == '1' && str2[i] == '0') || (str1[i] == '0' && str2[i] == '1'))
                    {
                        res2 = "0" + res2;
                        carry = 1;
                        continue;
                    }
                    else if ((str1[i] == '1' && str2[i] == '1'))
                    {
                        res2 = "1" + res2;
                        carry = 1;
                        continue;
                    }
                }
            }
            res2 = carry + res2;
            double final_result = BinaryToDecimal(res1, res2);
            return final_result;
        }//end of addBinary Method

        /// <summary>
        /// this method will convert the binary values into double values
        /// </summary>
        /// <param name="res1"></param>
        /// <param name="res2"></param>
        /// <returns></returns>
        public double BinaryToDecimal(string res1, string res2)
        {
            double int_result = 0;
            int temp = 0;
            for (int i = res2.Length - 1; i >= 0; i--)
            {
                if (res2[i] == '1')
                {
                    int_result += Math.Pow(2, temp);
                }
                temp = temp + 1;
            }
            double decimal_result = 0;
            temp = -1;
            int end = res1.Length - 1;
            int start = 0;
            while (start <= end)
            {
                if (res1[start] == '1')
                {
                    decimal_result += Math.Pow(2, temp);
                }
                start = start + 1;
                temp = temp - 1;
            }
            double final_result = 0.0;
            final_result = int_result + decimal_result;
            return final_result;
        }//end of BinaryToDecimal Method
    }
}