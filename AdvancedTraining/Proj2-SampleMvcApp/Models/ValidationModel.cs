using System.ComponentModel.DataAnnotations;

namespace SampleMvcApp.Models.Validation
{
    public class Employee
    {
        [Required(ErrorMessage = "Id is mandatory")]
        [Range(10, 100, ErrorMessage ="ID should be b/w 10 to 100")]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20, ErrorMessage = "Name cannot be more than 20 charecters")]
        public string EmpName { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage ="Invalid Format")]
        public string EmailAddress { get; set; } = string.Empty;

    }
}
