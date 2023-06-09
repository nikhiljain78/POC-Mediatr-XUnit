namespace MediatorCQRS_NUnit.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public int EmployeeAge { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}