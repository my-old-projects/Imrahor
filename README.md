# Imrahor

Simple task runner in .NET. Does nothing. It was my university project. I just added some new .NET Core features such as `new()`.

The system basically works with plugins you write. For example, you create a plugin called MyPlugin. You should call it in your task runner.

## MyPlugin.cs

```cs
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
```

## Program.cs

```cs
PluginManager myInfo = new MyPlugin();

ImrahorTask imrahor = new("myTaskInstance");
imrahor.AddTask("run-my-info", myInfo.Plugins());

Console.Write("Enter task name: ");

string taskName = Console.ReadLine(); // run-my-info

imrahor.RunTask(taskName);
```