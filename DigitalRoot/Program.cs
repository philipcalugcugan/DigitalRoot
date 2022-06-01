using System;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digital root is the recursive sum of all the digits in a number.
                Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.
            
                Example:
                    16  -->  1 + 6 = 7
                    942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
                    132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
                    493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
            */

            var digitalRootHelper = new DigitalRootHelper();
            Console.WriteLine(digitalRootHelper.DigitalRoot(16)); // Answer 1
            Console.WriteLine(digitalRootHelper.DigitalRoot(942)); // Answer 2
            Console.WriteLine(digitalRootHelper.DigitalRoot(132189)); // Answer 3
            Console.WriteLine(digitalRootHelper.DigitalRoot(493193)); // Answer 4

            Console.ReadLine(); // Wait for press key before exit
        }
    }
}
