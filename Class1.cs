using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace stringcalc
{
    public class StringCalculator
    {
        public static string Sum(string input)
        {
            if(string.IsNullOrEmpty(input)) //empty string
            {
                return "0";
            }

            //if(input.Length == 1)  //single value string// this is vaild only when there is a single digit like 1 or 2 etc
            //{
            //    return input;
            //}

            char[] separators = { ',', '\n' };
            //handling separators at ending of string
            char lastChar = input[input.Length - 1];
            if(separators.Contains(lastChar))
            {
                return "Number expected but EOF found.";
            }

            //handling 2 consecutive separators
            for (int i = 0; i < input.Length - 1; i++)
            {
                char current = input[i];
                char next = input[i + 1];

                if (separators.Contains(current) && separators.Contains(next))
                {
                    string sepText = next == '\n' ? "\\n" : next.ToString();
                    return $"Number expected but '{sepText}' found at position {i + 1}.";

                }
            }

            //for sum of input separated by ',' , '\n
            string[] parts = input.Replace("\n", ",").Split(',');
                       
            decimal sum = 0m;

            foreach (string part in parts)
            {
                string trimmed = part.Trim();
                if (trimmed.Length == 0)
                    return "Number expected but EOF found.";
                                
                sum += Convert.ToDecimal(trimmed);
            }
                     
            return sum.ToString();

        }
    }
}
