using Imrahor.Abstract;
using Imrahor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imrahor.Plugins
{
    public class MyPlugin : PluginManager
    {
        public MyPlugin()
        {

        }

        public string AskName()
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            return name;
        }

        private IPluginInterface HelloWorldPlugin()
        {
            this.Writeln("Hello world!\n");

            return this;
        }

        private IPluginInterface AskNamePlugin()
        {
            string name = this.AskName();

            this.Writeln($"\nYour name is {name}\n");

            return this;
        }

        public override PluginFunc Plugins()
        {
            var plugins = new PluginFunc();

            plugins.Add(HelloWorldPlugin);
            plugins.Add(AskNamePlugin);

            return plugins;
        }

    }
}
