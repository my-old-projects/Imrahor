using Imrahor.Base;
using Imrahor.Abstract;
using Imrahor.Interfaces;
using Imrahor.Plugins;
using System;
using System.Collections.Generic;

namespace Imrahor
{
    class Program
    {
        static void Main(string[] args)
        {
            PluginManager ramPlugin = new RamPlugin();
            PluginManager myInfo = new MyPlugin();

            ImrahorTask imrahor = new("myTaskInstance");
            imrahor.AddTask("run-my-info", myInfo.Plugins());
            imrahor.AddTask("run-system-info", ramPlugin.Plugins());

            Console.Write("Enter task name: ");

            string taskName = Console.ReadLine();

            imrahor.RunTask(taskName);
        }
    }
}
