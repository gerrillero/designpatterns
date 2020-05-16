using System;

namespace Mediator
{
    public abstract class UIControl
    {
        public event EventHandler ControlChanged;

        protected void OnControlChanged()
        {
            ControlChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
