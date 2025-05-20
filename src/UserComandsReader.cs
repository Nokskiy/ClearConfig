using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClearConfig.src;
using ClearConfig.src.Commands;

namespace ClearConfig
{
    public class UserComandsReader
    {
        public static Dictionary<string, string> commandList { get; } = new Dictionary<string, string>()
        {
            {"help","prints all commands"},
            {"update_links","updates the list of links"},
            {"remove", "deletes everything from config files"},
            {"remove_rec", "deletes everything from config files recursive"}
        };
        public static async Task DoCommand(string line)
        {
            var cmd = CommandParser.GetElementOfCommand(line, 0);
            switch (cmd)
            {
                case "help":
                    await new CommandHelp(line).RunExecution();
                    break;
                case "update_links":
                    await new CommandUpdateLinks(line).RunExecution();
                    break;
                case "remove":
                    await new CommandRemove(line).RunExecution();
                    break;
                case "remove_rec":
                    await new CommandRemoveRecursive(line).RunExecution();
                    break;
                default:
                    Error();
                    break;
            }
        }

        private static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("command not found");
            Console.ResetColor();
        }
    }
}