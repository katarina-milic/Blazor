using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;




namespace Blazor.Shared
{
  
    public class Film
    {

        [Column("id")]
        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Zanr { get; set; }
        [Required]
        
        public List<DatumProjekcije> Projekcije { get; set; } = new List<DatumProjekcije>();




    }

}
