using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Net.WebSocket;

namespace DiscordBotApp
{
    class Program
    {
        static DiscordClient discord;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "MzY2ODg1MjcyMjc0NzMxMDA5.DLzYHQ.nNwY_5OA4GqE-cBEiCl3fniCttg",
                TokenType = TokenType.Bot
            });

            discord.SetWebSocketClient<WebSocket4NetClient>();

            discord.MessageCreated += async e =>
            {
                // waits for a query from user "??"
                if (e.Message.Content.StartsWith("??"))
                    await e.Message.RespondAsync(BotResponse.BotReply(e.Message.Content.ToLower())); 
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
