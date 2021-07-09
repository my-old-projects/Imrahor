using Imrahor.Abstract;
using Imrahor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imrahor.Base
{
    public class ImrahorTask
    {
        private string _projectName;
        private List<ITask> Tasks { get; set; } = new List<ITask>();

        public ImrahorTask(string projectName = "")
        {
            _projectName = projectName;
        }

        public void AddTask(string taskName, PluginFunc plugins = null)
        {
            
            ITask task = new ImrohotTask
            {
                TaskName = taskName,
                Plugins = plugins.GetFuncs()
            };

            Tasks.Add(task);
            
        }

        public void RunTask(string taskName)
        {
            Console.WriteLine($"Task {taskName} running for project {_projectName}\n");

            var task = Tasks.Where(t => t.TaskName == taskName).FirstOrDefault();

            for (int i = 0; i < task.Plugins.Count(); i++)
            {
                var plugin = task.Plugins.ElementAt(i);

                plugin?.Invoke();
            }

            Console.WriteLine($"Task {taskName} ended for project {_projectName}\n");
        }
    }
}
