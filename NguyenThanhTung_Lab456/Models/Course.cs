using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenThanhTung_Lab456.Models
{
    public class Course
    {
        public int ID { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerID { get; set; }
    }
}