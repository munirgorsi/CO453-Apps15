using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WebApps.Models
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    public class Student
    {
      public int StudentId { get; set; }
        [StringLength(20), Required]
        public string Name { get; set; }
        [Range(0, 100)]
        {
        public int Mark { get; set;}
    }
}
