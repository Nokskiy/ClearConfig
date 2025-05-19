using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClearConfig.src
{
    public static class CommandParser
    {
        public static string GetElementOfCommand(string line, int num)
        {
            return Regex.Split(line, "\\s")[num];
        }
        
        public static int GetElementsOfCommandCount(string line)
        {
            return Regex.Split(line, "\\s").Length;
        }
    }
}