using System;
using System.Linq;

namespace ConsoleAppExtensionMethodDemo
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if(!string.IsNullOrEmpty(inputstring))
            {
                string[] strArray = inputstring.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string myWord = "Welcome to Extension Methods Example";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("String : " +myWord);
            Console.WriteLine("Count : " + wordCount);
            Console.Read();
        }
    }
}
