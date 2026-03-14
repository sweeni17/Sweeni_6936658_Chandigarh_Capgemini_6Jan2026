namespace Employee_Project_Management_System.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
