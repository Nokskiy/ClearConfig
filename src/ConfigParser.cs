using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClearConfig
{
    public static class ConfigParser
    {
        public static async Task<string> GetAllText(string path = "")
        {
            path = path == "" ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ClearConfig.config" : path;
            path = Path.GetFullPath(path);
            return await File.ReadAllTextAsync(path);
        }

        public static short GetLinesCount(string path = "")
        {
            path = path == "" ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ClearConfig.config" : path;
            path = Path.GetFullPath(path);
            return (short)File.ReadAllLines(path).Count();
        }

        public static async Task<string> GetAllTextInLine(string path = "", int line = 0)
        {
            path = path == "" ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ClearConfig.config" : path;
            path = Path.GetFullPath(path);
            return (await File.ReadAllLinesAsync(path))[line];
        }

        public static async Task<string> GetAllTextInLine(int line = 0, string path = "")
        {
            path = path == "" ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ClearConfig.config" : path;
            path = Path.GetFullPath(path);
            return (await File.ReadAllLinesAsync(path))[line];
        }

        public static string[] SplitToWords(string text)
        {
            return Regex.Split(text, "\\s");
        }

        public static string GetType(string text)
        {
            return SplitToWords(text)[0];
        }

        public static string GetValue(string text)
        {
            return SplitToWords(text)[1];
        }
    }
}