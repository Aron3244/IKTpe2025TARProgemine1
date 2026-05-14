using System.ComponentModel.DataAnnotations;

namespace University.ViewModel
{
    public class StudentDeleteViewModel
    {
        public int Id { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
      
        [Display(Name = "First Mid Name")]
        public string FirstMidName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<EnrollmentViewModel> EnrollmentsVm { get; set; }
    }
}

