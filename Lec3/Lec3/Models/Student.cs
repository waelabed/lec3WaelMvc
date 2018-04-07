using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWorkLec2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public String name { get; set; }
        public int Degree { get; set; }
        public virtual  Lesson LessonId { get; set; }
        public int Age { get; set; }
        public DateTime DateAdd { get; set; }

    }
}