/* 
        0 1 1 2 3 5 8 13 21 34
        fib(n) = fib(n-1) + fib(n-2)
        Ex. 
                fib(0) = 0
                fib(1) = 1
                fib(5) = 5
                fib(6) = 8
*/

using System;

namespace _99_csharp_problems 
{
        class Fibonnaci 
        {
                public static void Main(string[] args) 
                {
                        Console.WriteLine(fib(7));
                }

                public static int fib(int n) 
                {
                        if(n == 0) 
                        {
                                return 0;
                        }
                        else if(n == 1) 
                        {
                                return 1;
                        }
                        else 
                        {
                                return fib(n - 1) + fib(n - 2);
                        }
                }
        }
}