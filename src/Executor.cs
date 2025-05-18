using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearConfig
{
    public static class Executor
    {
        private static List<string> _links = new List<string>();
        public static async Task GetLinks(bool print = true)
        {
            _links.Clear();
            for (int line = 0; line < ConfigParser.GetLinesCount(); line++)
            {
                var lineText = await ConfigParser.GetAllTextInLine(line);
                if (ConfigParser.GetCommand(lineText) == "link")
                {
                    _links.Add(ConfigParser.GetValue(lineText));
                }
            }
            if(print)
                PrintLinks();
        }

        private static void PrintLinks()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Links list:");
            for (int i = 0; i < _links.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + " " + _links[i]);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}