using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Domain.Entities
{
    public class Student : BaseEntity
    {
        [Required]
        public string NRIC { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, StringLength(1)]
        public string Gender { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Birthday { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime? AvailableDate { get; set; }

        public virtual IEnumerable<StudentSubject> Subjects { get; set; }
    }
}
