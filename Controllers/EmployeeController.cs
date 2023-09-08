using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController:Controller
    {
        public IActionResult Index1()
        {
            string message =$"Hello World!.{DateTime.Now.ToString()}";
            return View("Index1",message);
        }
        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ali",
                "Orçun",
                "Ömer"
            };
            return View(names);
        }
        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1,FirstName="Ali Eyüp",LastName="Doğan",Age=25},
                new Employee(){Id=2,FirstName="Orçun",LastName="Okan",Age=30},
                new Employee(){Id=3,FirstName="Ömer",LastName="aydoğdu",Age=20},
                
            };
            return View("Index3", list);
        }
    }
}