using Casgem_ChainOfResponsibilty.DAL;
using Casgem_ChainOfResponsibilty.Models;
using System.Diagnostics.Eventing.Reader;
using System.Security.AccessControl;

namespace Casgem_ChainOfResponsibilty.ChainOfResponsibilty
{
    public class Treaurer : Empolyee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 5000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Mert Çaa";
                customerProcess.Des = "müşterinin talep ettiği tutar veznedar tarafından ödendi. ";


                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();



            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Mert Çaa";
                customerProcess.Des = "müşteri tarafından talep edilen tutar günlük ödeme bakiyemi aştığı için işlemi şube müdür yardımcısına gönderilmiştir. ";
                context.CustomerProcesses.Add(customerProcess);
                NextApprover.ProcessRequest(req);
            }

        }
    }
}
