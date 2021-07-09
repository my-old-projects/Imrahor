using Imrahor.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imrahor.Abstract
{
    public class PluginFunc
    {
        private List<Func<IPluginInterface>> _plugins = new List<Func<IPluginInterface>>();
        public PluginFunc()
        {

        }

        public void Add(Func<IPluginInterface> value)
        {
            _plugins.Add(value);
        }

        public int Count()
        {
            return _plugins?.Count ?? 0;
        }

        public Func<IPluginInterface> ElementAt(int index)
        {
            return _plugins.ElementAt(index);
        }

        public List<Func<IPluginInterface>> GetFuncs()
        {

            return _plugins;
        }
    }
}
