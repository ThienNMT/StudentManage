using StudentManage.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Entities
{
    public class StudentSubject : BaseEntity
    {
        [ForeignKey("Student")]
        [Required]
        public int StudentId { get; set; }

        [ForeignKey("Subject")]
        [Required]
        public int SubjectId { get; set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
