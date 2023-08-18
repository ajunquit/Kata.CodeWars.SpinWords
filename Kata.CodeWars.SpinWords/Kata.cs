using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CodeWars.SpinWords
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                throw new ArgumentException(nameof(sentence) + " is null or empty.");

            List<string> words = sentence.Split(' ', StringSplitOptions.None).ToList();

            for (int i = 0; i < words.Count; i++)
            {
                if (string.IsNullOrEmpty(words[i]))
                    continue;

                if (words[i].Count() < 5)
                    continue;

                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            return string.Join(" ", words);
        }
    }
}
