namespace EmployeeAndDepartment.Models
{
    public class EmployeeDepartment
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }

        // Navigation properties
        public Employee? Employee { get; set; }
        public Department? Department { get; set; }
    }
}
