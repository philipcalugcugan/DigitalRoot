using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalRoot
{
    public class DigitalRootHelper
    {
        public int DigitalRoot(long n)
        {
            return DigitalRootCreator(n);
        }

        private int DigitalRootCreator(long input)
        {
            int output = 0;
            bool isCompleted = false;
            string inputInStr = input.ToString();

            while (!isCompleted)
            {
                var inputArr = inputInStr.ToCharArray();
                inputInStr = GetTotalOfInputArr(inputArr).ToString();

                if (inputInStr.ToCharArray().Length == 1)
                {
                    isCompleted = true;
                    output = System.Convert.ToInt32(inputInStr);
                }
            }
            return output;
        }

        private int GetTotalOfInputArr(char[] inputArr)
        {
            var output = 0;

            foreach (var single in inputArr)
            {
                var wkInt = 0;
                var isConverted = int.TryParse(single.ToString(), out wkInt);

                if (isConverted)
                {
                    output += wkInt;
                }
            }

            return output;
        }
    }
}
