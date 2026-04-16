 namespace MyWebApiProject.Models
{
 public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign Key
        public int EmployeeTypeId { get; set; }

        // Navigation Property
        public EmployeeType EmployeeType { get; set; }
    }}

