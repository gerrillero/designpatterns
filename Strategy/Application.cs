namespace Strategy
{

    public abstract class Application
    {
        private readonly IApplicationBehavior applicationBehavior;

        public Application(IApplicationBehavior applicationBehavior)
        {
            this.applicationBehavior = applicationBehavior;
        }

        public void PerformClose()
        {
            applicationBehavior.Close();
        }

        public void PerformOpen()
        {
            applicationBehavior.Open();
        }
    }
}
