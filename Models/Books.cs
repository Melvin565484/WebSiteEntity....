using System;
using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Book
    {
        [Key]
        public int bookID {get; set;}

        [Required(ErrorMessage ="Title is required")]
        [Display(Name ="Title")]

        public string title {get; set;}

        [Required(ErrorMessage ="Subtitle is required")]
        [Display(Name ="Subtitle")]
        public string subtitle {get; set;}

        [Required(ErrorMessage ="ISBN is required")]
        [Display(Name ="ISBN")]
        public string ISBN {get; set;}

        [Required(ErrorMessage ="Published date is required")]
        [DataType(DataType.Date)]
        [Display(Name ="Publishedate")]
        public string publishedate {get; set;}

        [Required(ErrorMessage ="Author is required")]
        [Display(Name ="Author")]
        public int authorID {get; set;}

        public Author Author {get; set;}
    }
}