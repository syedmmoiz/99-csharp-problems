/* 
        0! = 1
        n! = n * (n - 1) * ... 1
        factorial(5) = 5 * 4 * 3 * 2 * 1 = 120      
*/
using System;

namespace _99_csharp_problems
{
        class Factorial 
        {
                public static void Main(string[] args) 
                {
                        Console.WriteLine(factorial(5));
                }

                public static int factorial(int n) 
                {
                        if(n == 0) 
                        {
                                return 1; 
                        }
                        else if(n == 1) 
                        {
                                return 1;
                        }
                        else 
                        {
                                return n * factorial(n - 1);
                        }
                }
        }
}