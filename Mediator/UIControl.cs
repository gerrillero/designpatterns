using System.Collections.Generic;

namespace Mediator
{
    public abstract class UIControl
    {
        private List<IEventHandler> observers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler observer)
        {
            observers.Add(observer);
        }

        protected void NotityObservers()
        {
            foreach (var observer in observers)
            {
                observer.Handle();
            }
        }
    }
}
