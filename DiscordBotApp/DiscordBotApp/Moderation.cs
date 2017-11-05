using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotApp
{
    class Moderation
    {
        internal static string file = "moderation.bin";
        internal static Dictionary<string, string> dict;

        /// <summary>
        /// Add words and synonyms to Dictionary
        /// </summary>
        /// <param name="word"></param>
        /// <param name="synonyms"></param>
        internal static void Add(string word, string synonyms)
        {
            
            if(File.Exists(file))
            {
                dict = Read();
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, synonyms);
                }
            }
            else
            {
                dict = new Dictionary<string, string>
                {
                    { word, synonyms }
                };
            }
            Console.WriteLine("Moderation Count: " + dict.Count);
            Write(dict);
        }

        internal static void Delete(string key)
        {
            dict = Read();
            dict.Remove(key);
            Write(dict);
        }

        internal static String Get()
        {
            if(File.Exists(file))
            {
                dict = Read();
                string moderation = "";
                foreach (var pair in dict)
                {
                    moderation = String.Concat(moderation, "({" + pair.Key + "},{" + pair.Value + "}),");
                }
                return moderation.TrimEnd(',');
            }
            else
            {
                return "nothing right now";
            }
        }

        internal static void Approve()
        {
            dict = Read();
            foreach(string word in dict.Keys)
            {
                Database.AddToDB(word, dict[word]);
            }
            // Remove the moderated file
            File.Delete(file);
        }

        static void Write(Dictionary<string, string> dictionary)
        {
            FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write); 
            using (BinaryWriter writer = new BinaryWriter(fs)) 
            {
                // Put count.
                writer.Write(dictionary.Count);
                // Write pairs.
                foreach (var pair in dictionary)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
                writer.Flush();
                writer.Close();
            }
        }

        static Dictionary<string, string> Read()
        {
            var result = new Dictionary<string, string>();
            using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read)) 
            using (BinaryReader reader = new BinaryReader(fs)) 
            {
                // Get count.
                int count = reader.ReadInt32();
                // Read in all pairs.
                for (int i = 0; i < count; i++)
                {
                    string key = reader.ReadString();
                    string value = reader.ReadString();
                    result[key] = value;
                }
            }
            return result;
        }
    }
}
