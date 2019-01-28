using System;

namespace binarytodecimal
{
    class Program
    {
        public static long binaryToDecimal()
        {
            int x, result= 0, q = 1, r;//declare variables
            Console.Write("Enter a binary number to get the decimal value     ");//display message
            x = int.Parse(Console.ReadLine());//input value to x
            while (x > 0)//while loop if x is positive
            {
                r = x % 10;//get remainder
                result = result + r * q;//start by multiplying remainder with 1
                x = x / 10;//get quotient
                q = q * 2;//multiply by 2
            }
            Console.Write("The decimal value is :"+ result);//print value of result
            Console.ReadLine();//hold output
            return 0;
        }
        static void Main(string[] args)
        {
            try
            {
                binaryToDecimal();
            }
            catch
            {
                Console.WriteLine("Please enter a valid binary value");
            }
        }
    }
}




