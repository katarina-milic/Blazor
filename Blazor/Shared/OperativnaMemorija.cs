using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Shared
{
    public class OpreativnaMemorija
    {
        public List<Sediste> VratiSedista()
        {
            var sedista = new List<Sediste>();
            for (int i = 1; i <= 30; i++)
            {
                var s = new Sediste()
                {
                    Id = i,
                    IsReserved = false
                };
                sedista.Add(s);
            }
            return sedista;
        }
    }

    public class RezSedista
    {
        public Rezervacija Rezervacija { get; set; }
        public List<Sediste> Sedista { get; set; }
    }
}
