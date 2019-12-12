using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Data.Entities
{
    class Projekcija
    {
        public int Id { get; set; }
        public Film Film { get; set; }
        public int FilmId { get; set; }
    }
}
