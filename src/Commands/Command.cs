using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearConfig.src
{
    public class Command
    {
        protected List<string> elements = new List<string>();

        protected Command(string commandLine)
        {
            for (int i = 0; i < CommandParser.GetElementsOfCommandCount(commandLine); i++)
            {
                this.elements.Add(CommandParser.GetElementOfCommand(commandLine, i));
            }
        }

        protected virtual async Task Execution()
        {
            await Task.CompletedTask;
        }

        public async Task RunExecution()
        {
            await Execution();
        }
    }
}