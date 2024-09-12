using Microsoft.AspNetCore.Mvc;
using MVC_Grid.Models;

namespace MVC_Grid.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var result = GetDetails();

            return View(result);
        }

        public IActionResult IndexFirst()
        {
            var result = GetDetails();

            return View("Index-First", result);
        }

        public IActionResult IndexFixSize()
        {
            var result = GetDetails();

            return View("Index-FixSize", result);
        }

        public IActionResult IndexResize()
        {
            var result = GetDetails();

            return View("Index-Resize", result);
        }

        public List<Employee> GetDetails()
        {
            List<Employee> result = new List<Employee>();

            result.Add(new Employee { ID = 1, Name = "John Kerry", Address = "Washington DC", Gender = "Male", Department = "Finance", Salary = 80000 });
            result.Add(new Employee { ID = 2, Name = "Joe Obama", Address = "Florida", Gender = "Male", Department = "Marketing", Salary = 75000 });
            result.Add(new Employee { ID = 3, Name = "Kamala Kennedy", Address = "Atlanta", Gender = "Female", Department = "Human Resources", Salary = 68000 });
            result.Add(new Employee { ID = 4, Name = "Alice Johnson", Address = "New York", Gender = "Female", Department = "IT", Salary = 90000 });
            result.Add(new Employee { ID = 5, Name = "Robert Brown", Address = "Los Angeles", Gender = "Male", Department = "Sales", Salary = 72000 });
            result.Add(new Employee { ID = 6, Name = "Emily Davis", Address = "Chicago", Gender = "Female", Department = "Finance", Salary = 81000 });
            result.Add(new Employee { ID = 7, Name = "Michael Smith", Address = "Houston", Gender = "Male", Department = "Operations", Salary = 85000 });
            result.Add(new Employee { ID = 8, Name = "Jennifer Taylor", Address = "Phoenix", Gender = "Female", Department = "Customer Support", Salary = 67000 });
            result.Add(new Employee { ID = 9, Name = "David Wilson", Address = "San Francisco", Gender = "Male", Department = "IT", Salary = 95000 });
            result.Add(new Employee { ID = 10, Name = "Sophia Martinez", Address = "Seattle", Gender = "Female", Department = "Legal", Salary = 88000 });

            return result;
        }

    }
}
