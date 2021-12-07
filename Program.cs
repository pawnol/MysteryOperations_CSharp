/*
 * Mystery Operators
 * Pawelski
 * 12/6/2021
 * Look over the code and predict what the program will 
 * print in the console. Record your prediction on the
 * activity sheet. Once you have made your prediction,
 * check your work by running the program. Lastly, answer
 * any questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 7;
            int number3 = -2;
            int number4 = 6;

            Console.WriteLine(number1 + number2 * number3);

            int result1 = number4 / (number3 * number1);
            Console.WriteLine(result1);

            int result2 = 0;
            result2 += number3 * number4;
            Console.WriteLine(result2);

            int result3 = number4 % number1;
            Console.WriteLine(result3);

            number1++;
            Console.WriteLine(number1);

            Console.WriteLine("3" + "3");
        }
    }
}
