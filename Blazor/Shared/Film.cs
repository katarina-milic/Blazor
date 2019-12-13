using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

/*enum Zanr
{
    KOMEDIJA,
    HOROR,
    ROMANTIKA,
    AKCIJA
}*/


namespace Blazor.Shared
{
   /* public enum Zanr
{
    KOMEDIJA,
    HOROR,
    ROMANTIKA,
    AKCIJA
}*/
     public class Film
    {
        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }
        public string Zanr { get; set; }
     
       
    }
    
}
