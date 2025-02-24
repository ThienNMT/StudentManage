using StudentManage.Domain.Enums;
using StudentManage.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Domain.DTOs
{
    public class StudentDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string NRIC { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Birthday { get; set; } = DateTime.Now;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime? AvailableDate { get; set; } = null;

        public DateTime CreatedDate { get; set; }
        public List<int> SelectedSubjects { get; set; } = new List<int>();


        public int Age
        {
            get
            {
                return StudentManageHelper.GetAge(Birthday);
            }
        }

        public int NumberOfSubjects
        {
            get
            {
                return SelectedSubjects.Count;
            }
        }

        public string ToLog()
        {
            return $"Id = {Id}, NRIC = {NRIC}, Name = {Name}, Gender = {Gender}, " +
                   $"DOB = {Birthday}, AvailableDate = {AvailableDate}, SelectedSubjects = ${SelectedSubjects.Count}";
        }
    }
}