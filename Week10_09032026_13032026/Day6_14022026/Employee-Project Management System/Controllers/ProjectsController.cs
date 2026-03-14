using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employee_Project_Management_System.Models;

namespace Employee_Project_Management_System.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly EPDbContext _context;

        public ProjectsController(EPDbContext context)
        {
            _context = context;
        }

        // show projects
        public IActionResult Index()
        {
            var projects = _context.Projects.ToList();
            return View(projects);
        }

        // GET Create
        public IActionResult Create()
        {
            return View();
        }

        // POST Create
        [HttpPost]
        public IActionResult Create(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // Dashboard view
        public IActionResult Dashboard()
        {
            var projects = _context.Projects
                .Include(p => p.EmployeeProjects)
                .ThenInclude(ep => ep.Employee)
                .ThenInclude(e => e.Department)
                .ToList();

            return View(projects);
        }
    }
}