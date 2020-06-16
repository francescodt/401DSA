using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructures.HashingTables
{
    public class RepeatedWord
    {

        public static string RepeatedWords(string words)
        {
            if (words == null || words == "")
                return null;

            HashTable myTable = new HashTable(100);
            var rx = new Regex(@"\s+l,\s+", RegexOptions.Compiled);
            string lowerCaseWords = words.ToLower();
            string[] allWords = rx.Split(lowerCaseWords);

            foreach (string word in allWords)
            {
                int index = HashTable.HashCode(word);
                HashTable.Node current = myTable.Buckets[index];

                if (myTable.Buckets[index] != null && current.Value == word)
                {
                    return word;
                }

                myTable.AddHash(word, word);
            }

            return null;
        }
    }
}
