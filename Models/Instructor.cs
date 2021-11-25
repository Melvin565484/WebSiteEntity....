using System;
using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorID {get; set;}

        [Required(ErrorMessage ="First name is required!")]
        [Display(Name ="firstName")]

        public string firstName {get; set;}

        [Required(ErrorMessage ="lastName is required!")]
        [Display(Name ="lastName")]
        public string lastName {get; set;}

        [Required(ErrorMessage ="phoneNumber is required!")]
        [Display(Name ="phoneNumber")]
        public string phoneNumber {get; set;}

        [Required(ErrorMessage ="certificate  is required!")]
        [Display(Name ="certificate")]
        public string certificate {get; set;}



      
    }
}