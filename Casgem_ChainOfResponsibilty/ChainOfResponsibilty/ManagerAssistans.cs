using Casgem_ChainOfResponsibilty.DAL;
using Casgem_ChainOfResponsibilty.Models;

namespace Casgem_ChainOfResponsibilty.ChainOfResponsibilty
{
    public class ManagerAssistans : Empolyee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Özge  Çaa";
                customerProcess.Des = "müşterinin talep ettiği tutar şube müdür yardımıcısı tarafından ödendi. ";


                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();



            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Özge Çaa";
                customerProcess.Des = "müşterinin talep ettiği tutar günlük ödeme bakiyemi aştığı için işlemi şube müdürüne yönlendirdim. ";


                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
