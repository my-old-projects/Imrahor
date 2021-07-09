using Imrahor.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imrahor.Interfaces
{
    public interface ITask
    {
        public string TaskName { get; set; }

        public IEnumerable<Func<IPluginInterface>> Plugins { get; set; }
    }
}
