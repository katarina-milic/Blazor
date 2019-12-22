using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor.Shared
{
    public class User
    {   [Required]
        public int Id { get; set; }
        [Required] [StringLength(30, ErrorMessage ="Korisnicko ime mora imati manje od 20 karaktera.")]
        public string Username { get; set; }
        [Required] [StringLength(30,ErrorMessage = "Unesite ime")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Unesite prezime")]
        public string LastName { get; set; }
        [Required]

        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
