using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App03
{
    public class Student
    {
        public int StudentId { get; set; }
        [StringLength(20), Required]
        public string Name { get; set; }
        [Range(0, 100)]
        
        public int Mark { get; set; }
    }
}
