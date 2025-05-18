using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearConfig
{
    public class UserComandsReader
    {
        private static Dictionary<string, string> _commandList = new Dictionary<string, string>()
        {
            {"help","prints all commands"},
            {"update links","updates the list of links"},
            {"remove", "deletes everything from config files"}
        };
        public static async Task DoCommand(string cmd)
        {
            switch (cmd)
            {
                case "help":
                    Help();
                    break;
                case "update links":
                    await UpdateLinks(true);
                    break;
                case "remove":
                    await Remove();
                    break;
                default:
                    Error();
                    break;
            }
        }

        private static void Help()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var i in _commandList)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        private static async Task UpdateLinks(bool print = false)
        {
            await Executor.GetLinks(print);
        }

        private static async Task Remove()
        {
            for (int line = 0; line < ConfigParser.GetLinesCount(); line++)
            {
                string lineText = await ConfigParser.GetAllTextInLine(line);
                string value = ConfigParser.GetValue(lineText);
                string fileName = Path.GetFileName(value);
                if (ConfigParser.GetCommand(lineText) == "link" && Path.Exists(value) && fileName == "ClearConfig.config")
                {
                    
                }
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