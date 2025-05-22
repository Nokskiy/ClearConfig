using System.Reflection;
using System.Threading.Tasks;

namespace ClearConfig
{
    public class Program
    {
        public static async Task Main()
        {
            while (true)
            {
                await ClearConfigLinksCheckExist();
                string cmd = Console.ReadLine() ?? "";
                await UserComandsReader.DoCommand(cmd.ToLower());
            }
        }

        private static async Task ClearConfigLinksCheckExist()
        {
            if (File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ClearConfig.config") == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                File.Create(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ClearConfig.config");
                Console.WriteLine("The configuration file is created for the first time, please adjust the config file and restart the program.");
                Console.ReadLine();
                Environment.Exit(0);
                Console.ResetColor();
            }
            else
            {
                await Executor.GetLinks(false);
            }
        }
    }
}