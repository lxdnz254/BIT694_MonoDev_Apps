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
                Boolean master = e.Message.Author.Username.Contains("lxdnz") && e.Message.Author.Discriminator.Equals("0605");
                string content = e.Message.Content.ToLower();
                // waits for a query from user "??"
                if (content.StartsWith("??"))
                    await e.Message.RespondAsync(BotResponse.BotReply(content));
                if (content.StartsWith("?+") && master)
                    await e.Message.RespondAsync("I hear you oh master! - " + BotResponse.BotAdd(content));
                if (content.StartsWith("?+") && !master)
                    await e.Message.RespondAsync("I do not take orders from imposters, " + BotResponse.BotUserAdd(content));
                if (content.StartsWith("?*") && master)
                    await e.Message.RespondAsync(BotResponse.BotUpdate(content));
                if (content.StartsWith("+?") && master)
                    await e.Message.RespondAsync("Master, the serfs wish to add :" + BotResponse.GetModeration());
                if (content.StartsWith("-?") && master)
                    await e.Message.RespondAsync(BotResponse.DeleteModeration(content));
                if (content.StartsWith("*?") && master)
                    await e.Message.RespondAsync(BotResponse.ApproveModeration());
            };

            await discord.ConnectAsync();
            ConsoleAsync.AsyncConsole(args).ConfigureAwait(false).GetAwaiter().GetResult();
            await Task.Delay(-1); 
        }
    }
}
