using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            char operator;
            int num1, num2,result;
            Console.WriteLine("enter first number and second number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            //result = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("enter the operator(+,-,*,/) ");
               operator=Convert.ToInt32(Console.ReadLine());
            switch (operator)
                {
                case +;
                    result = num1 + num2;
                Console.WriteLine("the sum of num1 and num2 is"+result);
                break;
                case -;
                result = num1 - num2;
                Console.WriteLine("the sum of num1 and num2 is" - result);
                break;
                case *;
                result = num1 * num2;
                Console.WriteLine("the sum of num1 and num2" * result);
                break;
                case /;
                result = num1 / num2;
                Console.WriteLine("the sum of num1 and num2" / result);
                break;
                default:
                    Console.WriteLine("error operator is not correct");
                break;
                }

        }
    }
}
