using System;

namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToCut = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(wordToCut))
            {
                int firstIndexToWordToRemove = text.IndexOf(wordToCut);
                text = text.Remove(firstIndexToWordToRemove, wordToCut.Length);
            }
            Console.WriteLine(text);
        }
    }
}
