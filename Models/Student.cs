using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DotNetCore1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(017|015|013|014|016|018|019)\d{8}$", ErrorMessage = "Mobile number must start with 017, 015, 013, 014, 016, 018, or 019 and be exactly 11 digits long.")]

        //[RegularExpression(@"^\d{11}$", ErrorMessage = "Mobile number must be exactly 11 digits.")]

        public string Mobile { get; set; }
        public string Address { get; set; }

    }
}
