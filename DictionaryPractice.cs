using System;
using System.Collections.Generic;

namespace _99_csharp_problems
{
    class DictionaryPractice 
    {
        static void Main(string[] args) 
        {
            string s = "abcd";
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
            Console.WriteLine();
            IDictionary<int, char> dict2 = new Dictionary<int, char>() 
            {
                {0, 'g'},
                {1, 'h'},
                {2, 'i'},
                {3, 'j'},
            };

            foreach(KeyValuePair<int, char> item in dict2) 
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }

            // Another example
            Console.WriteLine();
            IDictionary<int, char> dict3 = new Dictionary<int, char>();

            for(int i = 0; i < s.Length; i++) 
            {
                dict3[i] = s[i];
            }

            foreach(KeyValuePair<int, char> item in dict3) 
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }
        }
    }
}