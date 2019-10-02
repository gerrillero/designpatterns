using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Strategies
{
    public class RegisterContext
    {
        private IRegister _register;

        public RegisterContext(IRegister register)
        {
            _register = register;
        }

        public void SetRegister(IRegister register)
        {
            _register = register;
        }

        public void Close()
        {
            _register.Close();
        }
    }
}
