using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Data.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Zanr { get; set; }
        public List <Projekcija> Projekcije { get; set; }
    }
}
