using System.ComponentModel.DataAnnotations;

namespace University.ViewModel
{
    public class StudentUpdateViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Last Name ")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "First Mid Name ")]
        public string FirstMidName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Enrollment Date ")]
        public DateTime EnrollmentDate { get; set; }
    }
}
