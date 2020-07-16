using System;
using System.Collections.Generic;

namespace _99_csharp_problems
{
    static class Anagram 
    {
            public static void Main(string[] args) 
            {
                    Console.WriteLine(isAnagram("abc", "cbaa"));
            }

            public static bool isAnagram(string one, string two) 
            {
                // basic check: if lengths are not equal then they are not anagrams
                // for word one, create a dictionary and put the letters as keys and frequencies as values
                // for word two, see if the letter is present in dict, if it is, decrease frequency by 1
                // all frequencies should be zero, if there are any negative or positive then that means not anagrams

                if(one.Length != two.Length) 
                {
                        return false;
                }
                else 
                {
                        IDictionary<char, int> dict1 = new Dictionary<char, int>();
                        
                        // Start populating the dict with chars from word one
                        for(int i = 0; i < one.Length; i++) 
                        {
                                char letter = one[i];
                                
                                if(dict1.ContainsKey(letter))
                                {
                                        dict1[letter] += 1;
                                }
                                else
                                {
                                        dict1[letter] = 1;
                                }
                        }

                        // Start decreasing frequencies based on letters from two
                        foreach(char c in two) 
                        {
                                if(dict1.ContainsKey(c)) 
                                {
                                        dict1[c] -= 1;
                                }
                        }

                        // Just a print to see the internal status of dict
                        foreach(KeyValuePair<char, int> kv in dict1) 
                        {
                                Console.WriteLine("{0}, {1}", kv.Key, kv.Value);
                        }

                        // If a frequency is not 0, return false, because two is not an anagram of one
                        foreach(int v in dict1.Values) 
                        {
                                if(v != 0) {
                                        return false;
                                }
                        }
                }

                return true;
            }
    }
}