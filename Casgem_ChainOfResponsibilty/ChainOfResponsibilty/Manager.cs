using Casgem_ChainOfResponsibilty.DAL;
using Casgem_ChainOfResponsibilty.Models;

namespace Casgem_ChainOfResponsibilty.ChainOfResponsibilty
{
    public class Manager : Empolyee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 200000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Burak  Çaa";
                customerProcess.Des = "müşterinin talep ettiği tutar şube müdür yardımıcısı tarafından ödendi. ";


                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();



            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Burak Çaa";
                customerProcess.Des = "müşterinin talep ettiği tutar günlük ödeme bakiyemi aştığı için işlemi bölge müdürüne yönlendirdim. ";


                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}