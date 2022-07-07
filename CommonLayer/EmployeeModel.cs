using System;
using System.ComponentModel.DataAnnotations;

namespace CommonLayer
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ProfileImage { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public string Notes { get; set; }
    }
}
