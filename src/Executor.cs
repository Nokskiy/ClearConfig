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
                if (ConfigParser.GetType(lineText) == "link")
                {
                    _links.Add(ConfigParser.GetValue(lineText));
                }
            }
            if (print)
                PrintLinks();
        }

        public static async Task Remove(string config)
        {
            for (int line = 0; line < ConfigParser.GetLinesCount(); line++)
            {
                string lineText = await ConfigParser.GetAllTextInLine(line);
                string value = ConfigParser.GetValue(lineText);
                string fileName = Path.GetFileName(value);

                if (config == "")
                {
                    await WorkWithLink(false);
                }
                else if (config == value)
                {
                    await WorkWithLink(true);
                }

                async Task WorkWithLink(bool withConfig)
                {
                    if (ConfigParser.GetType(lineText) != "link" || !Path.Exists(value) || fileName != "ClearConfig.config")
                    {
                        for (int lineInConfig = 0; lineInConfig < ConfigParser.GetLinesCount(value); lineInConfig++)
                        {
                            string configLineText = await ConfigParser.GetAllTextInLine(lineInConfig, value);
                            string condition = ConfigParser.GetType(configLineText);
                            string configValue = ConfigParser.GetValue(configLineText);

                            switch (condition)
                            {
                                case "extension":
                                    RemoveByExtenition(configValue, Path.GetDirectoryName(value) ?? "");
                                    break;
                            }
                        }
                    }
                    
                }
            }
        }

        private static void RemoveByExtenition(string extenition, string configPath)
        {
            foreach (var i in Directory.GetFiles(configPath))
            {
                if (Path.GetExtension(i) == extenition)
                {
                    File.Delete(i);
                }
            }
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