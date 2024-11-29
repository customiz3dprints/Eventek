using CommandSystem;
using PluginAPI.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventek.Commands
{
    internal class Nukerun : ICommand
    {
        public string Command { get; set; } = "NR";
        public string Description { get; set; } = "yes";
        public string[] Aliases { get; set; } =  new string[] { "yes" };
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = null;
            return true;
        }
    }
}
