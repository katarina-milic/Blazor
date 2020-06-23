using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blazor.Shared
{
    public class DatumProjekcije
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        //public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
