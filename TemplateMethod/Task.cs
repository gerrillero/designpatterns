using Autofac;

namespace TemplateMethod
{
    public abstract class Task
    {
        private readonly IAuditTrail auditTrail;

        public Task()
        {
            auditTrail = ContainerConfig.Container.Resolve<IAuditTrail>();
        }

        public void Execute()
        {
            auditTrail.Record();

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
