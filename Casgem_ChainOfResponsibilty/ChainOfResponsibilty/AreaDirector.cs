using Casgem_ChainOfResponsibilty.DAL;
using Casgem_ChainOfResponsibilty.Models;

namespace Casgem_ChainOfResponsibilty.ChainOfResponsibilty
{
    public class AreaDirector : Empolyee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 300000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Fevzi  Çaa";
                customerProcess.Des = "müşterinin talep ettiği tutar bölge müdürü tarafından ödendi. ";


                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();



            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Fevzi Çaa";
                customerProcess.Des = "müşterinin talep ettiği tutar günlük ödeme bakiyemi aştığı için işlem gerçekleştirilemedi. ";


                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
        }
    }
}
