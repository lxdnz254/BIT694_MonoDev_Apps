using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    static class StopWords
    {
        /// <summary>
        /// Words we want to remove.
        /// </summary>
        static Dictionary<string, bool> _stops = new Dictionary<string, bool>
    {
        { "a", true },
        { "all", true },
        { "also", true },
        { "am", true },
        { "an", true },
        { "and", true },
        { "any", true },
        { "are", true },
        { "as", true },
        { "at", true },
        { "be", true },
        { "but", true },
        { "by", true },
        { "can", true },
        { "cannot", true },
        { "cant", true },
        { "co", true },
        { "con", true },
        { "de", true },
        { "do", true },
        { "eg", true },
        { "etc", true },
        { "few", true },
        { "for", true },
        { "get", true },
        { "go", true },
        { "had", true },
        { "has", true },
        { "he", true },
        { "her", true },
        { "hers", true },  
        { "him", true },
        { "his", true },
        { "how", true },
        { "i", true },
        { "ie", true },
        { "if", true },
        { "in", true },
        { "inc", true },
        { "is", true },
        { "it", true },
        { "its", true },
        { "ltd", true },
        { "may", true },
        { "me", true },
        { "my", true },
        { "no", true },
        { "nor", true },
        { "not", true },
        { "now", true },
        { "of", true },
        { "off", true },
        { "on", true },
        { "one", true },
        { "only", true },
        { "onto", true },
        { "or", true },
        { "our", true },
        { "ours", true },
        { "out", true },
        { "own", true },
        { "per", true },
        { "put", true },
        { "re", true },
        { "see", true },
        { "she", true },
        { "so", true },
        { "than", true },
        { "that", true },
        { "the", true },
        { "to", true },
        { "too", true },
        { "top", true },
        { "two", true },
        { "un", true },
        { "up", true },
        { "us", true },
        { "via", true },
        { "was", true },
        { "we", true },
        { "yet", true },
        { "you", true },
        { "your", true },
        { "you'll", true }
        
    };

        /// <summary>
        /// Chars that separate words.
        /// </summary>
        static char[] _delimiters = new char[]
        {
        ' ',
        ',',
        ';',
        '.'
        };

        /// <summary>
        /// Remove stopwords from string.
        /// </summary>
        public static string RemoveStopwords(string input)
        {
            // 1
            // Split parameter into words
            var words = input.Split(_delimiters,
                StringSplitOptions.RemoveEmptyEntries);
            // 2
            // Store results in this StringBuilder
            StringBuilder builder = new StringBuilder();
            // 3
            // Loop through all words
            foreach (string currentWord in words)
            {
                // 4
                // Convert to lowercase
                string lowerWord = currentWord.ToLower();
                // 5
                // If this is a usable word, add it
                if (!_stops.ContainsKey(lowerWord))
                {
                    builder.Append(currentWord).Append(' ');
                   
                }
            }
            // 6
            // Return string with words removed
            return builder.ToString().Trim();
        }
    }
}

