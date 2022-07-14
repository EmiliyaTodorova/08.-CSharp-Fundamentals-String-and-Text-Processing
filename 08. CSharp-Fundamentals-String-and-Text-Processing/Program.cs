using System;

namespace _08._CSharp_Fundamentals_String_and_Text_Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allWords = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;
            foreach(string word in allWords)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    result += word;

                }
            }
            Console.WriteLine(result);
        }
    }
}
