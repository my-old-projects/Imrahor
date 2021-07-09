using Imrahor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imrahor.Abstract
{
    public abstract class PluginManager : IPluginInterface
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void Writeln(string text)
        {
            Console.WriteLine(text);
        }

        public abstract PluginFunc Plugins();
    }
}
