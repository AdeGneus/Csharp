using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string word = "Wasiu";
            static void IsPalindrome(string word)
            {
                string wordReversed;
                for (int i = word.Length - 1; i >= 0 ; i--)
                {
                    wordReversed += word[i];
                }
                Console.WriteLine(wordReversed);
            } 
            Console.WriteLine("Hello World!");
            IsPalindrome(word);*/
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            static void IsPalindrome(string word)
            {
                for (int i = 0; i < word.Length/2; i++)
                {
                    if (word[i] != word[word.Length-1-i])
                    {
                        Console.WriteLine("The word is not a palindrome");
                    } else
                    {
                        Console.WriteLine("The word is a palindrome");
                    }
                }
            }
            IsPalindrome(word);
        }
    }
}
