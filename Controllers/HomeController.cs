using EmpManagment.Model;
using Microsoft.AspNetCore.Mvc;
namespace EmpManagment.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ObjectResult Details()
        {
            //Employee employee=_iEmployee.GetEmpolyee(1);
            Employee model=_employeeRepository.GetEmpolyee(1);
            return new ObjectResult(model);
        }
        // public JsonResult Index()
        // {
        //     //Employee employee=_iEmployee.GetEmpolyee(1);
        //     return Json((Employee)_employeeRepository.GetEmpolyee(1));
        // }
    }
}