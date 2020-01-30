﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name ="First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [Display(Name ="Hird Date")]
        public DateTime HireDate { get; set; }
        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + "," + FirstMidName;
            }
        }

        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        public OfficeAssignment OfficeAssignment { get; set; }
    }
}
