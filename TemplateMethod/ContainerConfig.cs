using Autofac;

namespace TemplateMethod
{
    /// <summary>
    /// This is part of Autofac dependecy injection container.
    /// </summary>
    public class ContainerConfig
    {
        public static IContainer Container { get; set; }

        public static void Config()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AuditTrail>().As<IAuditTrail>();
            Container = builder.Build();

        }

    }
}
