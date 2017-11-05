using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotApp
{
    static class ConsoleAsync
    {
        internal static async Task AsyncConsole(string[] args)
        {
            var consoleLine = Console.ReadLine();
            if (consoleLine == "")
            {
                Console.WriteLine("Master, the serfs wish to add :" + BotResponse.GetModeration());
                AsyncConsole(args).ConfigureAwait(false).GetAwaiter().GetResult();
            };
            if (consoleLine.StartsWith("??"))
            {
                Console.WriteLine(BotResponse.BotReply(consoleLine));
                AsyncConsole(args).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            if (consoleLine.StartsWith("-?"))
            {
                Console.WriteLine(BotResponse.DeleteModeration(consoleLine));
                AsyncConsole(args).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            if (consoleLine == "OK")
            {
                Console.WriteLine(BotResponse.ApproveModeration());
                AsyncConsole(args).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            if (consoleLine.StartsWith("++"))
            {
                Console.WriteLine(BotResponse.BotAdd(consoleLine));
                AsyncConsole(args).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            if (consoleLine.StartsWith("**"))
            {
                Console.WriteLine(BotResponse.BotUpdate(consoleLine));
                AsyncConsole(args).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            if (consoleLine.StartsWith("+?"))
            {
                Console.WriteLine("Trick me master, " + BotResponse.BotUserAdd(consoleLine));
                AsyncConsole(args).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            await Task.Delay(-1);
        }
    }
}
