using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotApp
{
    public static class BotResponse
    {
        internal static String BotReply(String message)
        {
            // Get responses based on query
            if (message.Contains("lol") && !message.Contains("loll"))
                return "I find that so funny too!";
            if (message.Contains("lxdnz"))
                return "All hail my great creator!";
            if (message.Contains("justin bieber"))
                return "No way, !next";
            if (message.Contains("gerd"))
                return "Oh no, the Gerds are coming!";

            // remove the ?? at start of message
            string newMessage = message.Substring(2);

            List<string> words = new List<string>();
            // check for more than one word
            if (newMessage.Contains(" "))
            {
                string[] splitWords = newMessage.Split(' ');
                foreach (string split in splitWords)
                {
                    words.Add(split);
                }
            }
            else
            {
                words.Add(newMessage);
            }
            
            // send the first word to the database
            string synonyms = Database.CheckDB(words[0]);
            if (synonyms != "")
            {
                return "Synonyms: " + synonyms;
            }
            
            // otherwise return default message
            return "I have a message for you :" + message;
        }
    }
}
