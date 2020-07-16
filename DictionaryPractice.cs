using System;
using System.Collections.Generic;

namespace _99_csharp_problems
{
    class DictionaryPractice 
    {
        static void Main(string[] args) 
        {
            string s = "abcdef";
            IDictionary<int, char> dict = new Dictionary<int, char>();

            // Adding Elements
            for(int i = 0; i < s.Length; i++) 
            {
                dict.Add(i, s[i]);
            }

            // Getting Elements
            for(int i = 0; i < dict.Count; i++) 
            {
                Console.WriteLine(dict[i]);
            }

            // Another example
            IDictionary<int, char> dict2 = new Dictionary<int, char>() 
            {
                {0, 'g'},
                {1, 'h'},
                {2, 'i'},
                {3, 'j'},
            };

            foreach(KeyValuePair<int, char> item in dict2) 
            {
                Console.WriteLine(item.Value);
            }

            foreach(int key in dict2.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}