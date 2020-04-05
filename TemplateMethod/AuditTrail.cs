using System;

namespace TemplateMethod
{
    public class AuditTrail : IAuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit");
        }

    }
}
