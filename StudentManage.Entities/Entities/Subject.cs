using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Domain.Entities
{
    public class Subject : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual IEnumerable<StudentSubject> Students { get; set; }
    }
}
