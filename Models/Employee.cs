using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Username { get; set; } = "";

        [MaxLength(100)]
        public string Password { get; set; } = "";

        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }
        [MaxLength(100)]
        public string? Department { get; set; }
    }
    
}
