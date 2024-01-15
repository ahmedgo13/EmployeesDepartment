namespace EmployeeAndDepartment.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public required string DepartmentName { get; set; }

        // Navigation
        public ICollection<Employee> Employees { get; set; }
    }
}
