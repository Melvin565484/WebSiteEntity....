using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace website.Models
{
 public class Author
 {
     [Key]
     //definir propiedades 
     public int authorID {get; set;}

     [Required(ErrorMessage ="First name is required!")]
     [Display(Name ="First name")]
     public string firstName {get; set;}

     [Required(ErrorMessage ="Last name is required!")]
     [DataType(DataType.EmailAddress)]
      [Display(Name ="Last name",Prompt ="email@admin.com")]
     public string lastName {get; set;}

     [Required(ErrorMessage ="Email name is required!")]
      [Display(Name ="Email")]
     public string email {get; set;}

     [Required(ErrorMessage ="Gender name is required!")]
      [Display(Name ="Gender")]
     public string gender {get; set;}

     [Required(ErrorMessage ="Adress name is required!")]
      [Display(Name ="Address")]
      [StringLength(300)]
      public string addres {get; set;}

      public ICollection<Book> Books {get; set; } = new List<Book>();
     
 }

}