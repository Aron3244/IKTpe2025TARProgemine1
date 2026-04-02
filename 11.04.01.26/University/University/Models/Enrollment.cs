using Microsoft.EntityFrameworkCore;

namespace University.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        public Course Course  { get; set; }
        public Student student  { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}
