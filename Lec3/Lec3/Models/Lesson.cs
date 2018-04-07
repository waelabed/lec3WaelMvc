using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWorkLec2.Models
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}