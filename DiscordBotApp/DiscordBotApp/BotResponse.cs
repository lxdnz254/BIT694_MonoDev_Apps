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
            if (message.Contains("help"))
                return "Commands are \"??*word*\" returns list of synonyms, \"?+*word* synonym1 synomym2 ...\" sends request to moderation.";

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

        /// <summary>
        /// Master adds an entry
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        internal static String BotAdd(String message)
        {
            string newMessage = message.Substring(2);
            string[] splitWords = newMessage.Split(' ');
            string synonyms = "";
            for(int i=1; i < splitWords.Length; i++)
            {
                synonyms += splitWords[i] + ',';
            }
             return Database.AddToDB(splitWords[0], synonyms.TrimEnd(','));
        }

        /// <summary>
        /// Master deletes the entry
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        internal static String BotDelete(String message)
        {
            string response = "";

            return response;
        }

        internal static String BotUpdate(String message)
        {
            string newMessage = message.Substring(2);
            string[] splitWords = newMessage.Split(' ');
            string synonyms = "";
            for (int i = 1; i < splitWords.Length; i++)
            {
                synonyms += splitWords[i] + ',';
            }
            return Database.UpdateToDB(splitWords[0], synonyms.TrimEnd(','));
        }

        internal static String BotUserAdd(String message)
        {
            string newMessage = message.Substring(2);
            string[] splitWords = newMessage.Split(' ');
            string synonyms = "";
            for (int i = 1; i < splitWords.Length; i++)
            {
                synonyms += splitWords[i] + ',';
            }
            Moderation.Add(splitWords[0], synonyms.TrimEnd(','));
            return "but your request has been sent to moderation";
        }

        internal static String BotUserDelete()
        {
            return "??You are an imposter, you may not delete the data, it is only permissible by lxdnz";
        }

        internal static String BotUserUpdate()
        {
            return "??I don't recognize your query, but it has been added to the moderation list for my master lxdnz";
        }

        internal static String GetModeration()
        {
            return Moderation.Get();
        }

        internal static String ApproveModeration()
        {
            Moderation.Approve();
            return "The serfs appreciate your approval.";
        }

        internal static String DeleteModeration(string message)
        {
            string newMessage = message.Substring(2);
            Moderation.Delete(newMessage);
            return newMessage + " has been removed from moderation";
        }
    }

    
}
