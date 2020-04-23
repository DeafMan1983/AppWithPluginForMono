using System;
using PluginBase;
namespace OtherPlugin
{
    public class OtherCommand : ICommand
    {
        public OtherCommand()
        {
        }

        public string Name { get => "other"; }

        public string Description { get => "Other message."; }

        public int Execute()
        {
            Console.WriteLine("Other Plugin ;-) ");
            return 0;
        }
    }
}
