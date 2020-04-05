using Autofac;

namespace TemplateMethod
{
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
