using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Department
    {
        [Key]
        public int DeapartmentId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Budget { get; set; }
        public DateTime StarDate { get; set; }
        //tähendab, et väli võib olla 0, sest see ei ole kohustuslik
        public int? InstructorId { get; set; }

        public Instructor Administrator { get; set; } 
        public ICollection<Course> Courses { get; set; }

    }
}
