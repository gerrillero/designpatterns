using Command.fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomeService customeService;

        public AddCustomerCommand(CustomeService customeService)
        {
            this.customeService = customeService;
        }
        public void Execute()
        {
            customeService.AddCostumer();
        }
    }
}