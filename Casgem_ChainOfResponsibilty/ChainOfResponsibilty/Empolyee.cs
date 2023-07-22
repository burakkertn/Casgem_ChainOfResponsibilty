using Casgem_ChainOfResponsibilty.Models;

namespace Casgem_ChainOfResponsibilty.ChainOfResponsibilty
{
    public abstract class Empolyee
    {
        protected Empolyee NextApprover;

        public void SetNextApprover(Empolyee Supervisor)
        {
            this.NextApprover = Supervisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);

    }
}
