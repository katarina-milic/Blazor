using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor.Shared
{
    public class User
    {
        [Required] [StringLength(30, ErrorMessage ="Korisnicko ime mora imati manje od 20 karaktera.")]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
       
        public string Password { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
