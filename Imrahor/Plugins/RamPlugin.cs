using Imrahor.Abstract;
using Imrahor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imrahor.Plugins
{
    public class RamPlugin : PluginManager
    {
        public RamPlugin()
        {

        }

        private long GetTotalMemory(bool forceFullCollection)
        {
            return GC.GetTotalMemory(forceFullCollection);
        }

        private IPluginInterface GetTotalMemoryPlugin()
        {

            long memory = this.GetTotalMemory(true);

            this.Writeln($"{memory} total memory!\n");

            return this;
        }

        public override PluginFunc Plugins()
        {
            var plugins = new PluginFunc();

            plugins.Add(GetTotalMemoryPlugin);

            return plugins;
        }
    }
}
