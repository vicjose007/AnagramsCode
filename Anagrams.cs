using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramProgram
{
    public class Anagram
    {
        public bool Anagram1(string word1, string word2)
        {
            string[] words = new string[9] {"kinship", "enlist", "boaster", "fresher", "sinks ","crepitus", "paste", "punctilio", "sunders"};
            string[] words2 = new string[9] { "pinkish", "inlets", "boaters", "refresh", "skins ", "cuprites", "pates", "unpolitic", "undress" };
            bool anagram = false;

            int count = 0;
            int count2 = 0;

            for (int i = 0; i < words.Length - 1; i++)
            {
                count++;
                count2 = words2.Length - 1;


                if (word2.Contains(words[i]) && count == count2)
                {
                    anagram = true;

                }
                return Anagram1(words[i], words2[i]);
            }
            return anagram;
        }
    }
}