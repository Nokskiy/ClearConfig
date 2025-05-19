using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearConfig.src
{
    public class CommandHelp : Command
    {
        public CommandHelp(string commandLine) : base(commandLine) { }

        protected override async Task Execution()
        {
            await base.Execution();
            
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var i in UserComandsReader.commandList)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}