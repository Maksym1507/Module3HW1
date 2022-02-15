using Autofac;
using Module3HW1.Configs;

namespace Module3HW1
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var start = container.Resolve<Starter>();
            start.Run();
        }
    }
}
