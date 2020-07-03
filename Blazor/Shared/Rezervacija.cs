using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor.Shared
{
    public class Rezervacija
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Film Film { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public DatumProjekcije Datum { get; set; }
        [Required]
        public List<Sediste> Sediste { get; set; } = new List<Sediste>();
       


    }   
}
