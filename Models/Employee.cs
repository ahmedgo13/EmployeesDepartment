namespace EmployeeAndDepartment.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; }

        public string? Position { get; set; }

        public int Salary { get; set; }

        public DateOnly DateOfBirth { get; set; }

        // Navigation
        public ICollection<Department> Departments { get; set; }
    }
}
