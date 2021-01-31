using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(123, "Zehra");

            Console.WriteLine(dictionary.Keys[0] + " : " + dictionary.Values[0]);
    
        }
    }
}
