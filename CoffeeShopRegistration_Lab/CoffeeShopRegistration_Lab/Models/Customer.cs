using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShopRegistration_Lab.Models
{
    public class Customer 
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Your passwords don't match")]
        [NotMapped]
        [Display(Name ="Please confirm your password")]
        public string ConfirmPassword { get; set; }

    }
}
