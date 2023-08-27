namespace FloatToBinaryConversion
{
    /// <summary>
    /// this class have various method to convert float to binary values
    /// </summary>
    public class FloatToBinaryConverter
    {
        /// <summary>
        /// this method uses 2 seperate methods to convert int to binary and float to binary of the given input
        /// </summary>
        /// <param name="input_number"></param>
        /// <returns></returns>
        public string FloatToBinary(double input_number)
        {
            int int_value = (int)input_number;
            double decimal_value = input_number - int_value;
            decimal_value = Math.Round(decimal_value, 10);
            string int_binary = IntToBinary(int_value);
            string float_binary = DecimalToBinary(decimal_value);
            return int_binary + '.' + float_binary;
        }//end of FloatToBinary Method

        /// <summary>
        /// this method will convert integer part of the input to binary value
        /// </summary>
        /// <param name="int_value"></param>
        /// <returns></returns>
        public string IntToBinary(int int_value)
        {
            string temp = "";
            string int_binary = "";
            while (int_value > 0)
            {
                temp = temp + (int_value % 2);
                int_value = (int_value / 2);
            }
            int right = temp.Length - 1;
            while (right >= 0)
            {
                int_binary = int_binary + temp[right];
                right--;
            }
            return int_binary;
        }//end of IntToBinary Method

        /// <summary>
        /// this method will convert decimal part of input to binary value
        /// </summary>
        /// <param name="decimal_value"></param>
        /// <returns></returns>
        public string DecimalToBinary(double decimal_value)
        {
            string temp = "";
            string decimal_binary;
            string result = "";
            List<double> vals = new List<double>();
            vals.Add(decimal_value);
            while (decimal_value > 0)
            {
                decimal_value = decimal_value * 2;
                decimal_value = Math.Round(decimal_value, 10);
                if (decimal_value >= 1)
                {
                    if (vals.Contains(decimal_value - 1))
                    {
                        break;
                    }
                    else
                    {
                        temp = temp + ("1");
                        decimal_value = decimal_value - 1;
                        vals.Add(decimal_value);
                    }
                }
                else
                {
                    temp = temp + ("0");
                    decimal_value = decimal_value - 1 + 1;
                    vals.Add(decimal_value);
                }
            }
            decimal_binary = '.' + temp;
            for (int i = 1; i < decimal_binary.Length; i++)
            {
                result += decimal_binary[i];
            }
            return result;
        }//end of DecimalToBinary Method
    }
}