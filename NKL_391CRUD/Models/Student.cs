using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKL_391CRUD.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string StudentName { get; set; }
    }
}

