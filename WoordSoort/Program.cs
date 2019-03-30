using System;
using System.Collections.Generic;
using System.Linq;

namespace WoordSoort
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Sorrt");
            string firstWord = "hand";
            string finalWord = "foot";

            WordSort(firstWord, finalWord);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }
        private static void WordSort(string firstWord, string finalWord)
        {
            List<string> wordSet = new List<string>(new string[] { "bear", "band", "bond", "cars", "fond", "food", "foot", "hand", "head" });
            wordSet = wordSet.Where(w => !w.Contains(firstWord)).ToList();

            string currentWord = firstWord;
            Console.WriteLine(currentWord);
            var nextWord = "";

            for (var i = 0; i < wordSet.Count; i++)
            {
                nextWord = wordSet[i];
                if (ValidateWords(currentWord, nextWord))
                {
                    currentWord = nextWord;
                    Console.WriteLine(nextWord);

                    if (nextWord == finalWord)
                        i = wordSet.Count;
                }
            }
        }

        private static bool ValidateWords(string currentWord, string nextWord)
        {
            int mismatch = 0;
            bool isValid = true;

            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i] != nextWord[i]) mismatch++;
                if (mismatch > 1)
                {
                    isValid = false;
                    break;
                }
                    
            }

            return isValid;
        }
    }
}
