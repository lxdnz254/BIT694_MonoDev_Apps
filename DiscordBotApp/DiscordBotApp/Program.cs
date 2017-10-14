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
                if (e.Message.Content.ToLower().StartsWith("ping"))
                    await e.Message.RespondAsync("ding!");
                if (e.Message.Content.ToLower().Contains("lol"))
                    await e.Message.RespondAsync("I find that so funny too!");
                if (e.Message.Content.ToLower().Contains("lxdnz"))
                    await e.Message.RespondAsync("All hail my great creator!");
                if (e.Message.Content.ToLower().Contains("justin bieber"))
                    await e.Message.RespondAsync("No way, !next");
                if (e.Message.Content.Contains("gerd"))
                    await e.Message.RespondAsync("Oh no, the Gerds are coming!");
                
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
