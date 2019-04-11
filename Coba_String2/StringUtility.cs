using System;
using System.Collections.Generic;
using System.Text;

namespace Coba_String2
{
    public class StringUtility
    {
        public static string SummerizeText(string sentence, int max = 20)
        {
            if (sentence.Length < max)
            {
                return sentence;
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > max)
                        break;
                }

                return String.Join(" ", summaryWords) + "...";
            }
        }
    }
}
