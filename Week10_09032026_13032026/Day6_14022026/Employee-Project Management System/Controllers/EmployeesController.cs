using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employee_Project_Management_System.Models;

namespace Employee_Project_Management_System.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EPDbContext _context;

        public EmployeesController(EPDbContext context)
        {
            _context = context;
        }

        // Show all employees
        public IActionResult Index()
        {
            var employees = _context.Employees
                .Include(e => e.Department)
                .ToList();

            return View(employees);
        }

        // GET Create
        public IActionResult Create()
        {
            ViewBag.Departments = _context.Departments.ToList();
            ViewBag.Projects = _context.Projects.ToList();

            return View();
        }

        // POST Create
        [HttpPost]
        public IActionResult Create(Employee employee, List<int> selectedProjects)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            // assign projects
            foreach (var projectId in selectedProjects)
            {
                EmployeeProject ep = new EmployeeProject
                {
                    EmployeeId = employee.EmployeeId,
                    ProjectId = projectId,
                    AssignedDate = DateTime.Now
                };

                _context.EmployeeProjects.Add(ep);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}