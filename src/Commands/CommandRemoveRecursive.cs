using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearConfig.src.Commands
{
    public class CommandRemoveRecursive : Command
    {
        public CommandRemoveRecursive(string commandLine) : base(commandLine) { }

        protected override async Task Execution()
        {
            await base.Execution();
            string config = "";
            if (base.elements.Count > 1 && base.elements[1] != "")
            {
                config = base.elements[1];
            }
            await Executor.Remove(config, true);
        }
    }
}