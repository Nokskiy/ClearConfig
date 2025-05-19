using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearConfig.src.Commands
{
    public class CommandUpdateLinks : Command
    {
        public CommandUpdateLinks(string commandLine) : base(commandLine) { }

        protected override async Task Execution()
        {
            await base.Execution();
            bool print = base.elements?.Count > 1 && base.elements[1] == "true";
            await Executor.GetLinks(print);
        }
    }
}