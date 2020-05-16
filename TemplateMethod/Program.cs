namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerConfig.Config();

            var taskMoney = new TransferMoneyTask();
            taskMoney.Execute();
        }
    }
}
