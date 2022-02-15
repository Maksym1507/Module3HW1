using Autofac;
using Module3HW1.Interfaces;
using Module3HW1.Collections;
using Module3HW1.Services;

namespace Module3HW1.Configs
{
    public class Config
    {
        public Config()
        {
            Builder = new ContainerBuilder();
        }

        private ContainerBuilder Builder { get; }

        public IContainer RegisterTypes()
        {
            Builder.RegisterType<NotificationService>().As<INotificationService>();
            Builder.RegisterType<MyImplementedList<int>>().As<IMyImplementedList<int>>();
            Builder.RegisterType<Starter>();
            return Builder.Build();
        }
    }
}
