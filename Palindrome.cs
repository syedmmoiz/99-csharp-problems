using System;
using System.Collections.Generic;

namespace _99_csharp_problems
{
        class Palindrome 
        {
                public Palindrome() { }

                public static void Main(string[] args) 
                {
                        Console.WriteLine(isPalindrome("a"));
                }

                public static bool isPalindrome(string one) 
                {
                        if(one.Length == 0) 
                        {
                                return false;
                        }

                        for(int i = 0; i < one.Length/2; i++) 
                        {       
                                int lastIndex = one.Length - 1;
                                
                                if(one[i] != one[lastIndex - i]) 
                                {
                                        return false;
                                }
                        }
                        
                        return true;
                }
        }
}