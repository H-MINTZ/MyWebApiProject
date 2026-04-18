 namespace MyWebApiProject.Models
{
 public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public int numHours { get; set; }

        // Foreign Key
        public int EmployeeTypeId { get; set; }

        // Navigation Property
        public EmployeeType EmployeeType { get; set; }
    }}

