using Casgem_ChainOfResponsibilty.ChainOfResponsibilty;
using Casgem_ChainOfResponsibilty.Models;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_ChainOfResponsibilty.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Empolyee treasurer = new Treaurer();
            Empolyee managaerAssitans = new ManagerAssistans();
            Empolyee manager = new Manager();
            Empolyee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(managaerAssitans);
            managaerAssitans.SetNextApprover(manager);  
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
