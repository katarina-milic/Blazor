using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Shared
{
    public class Sesija
    {
        private static Sesija instance;
        public List<DatumProjekcije> Projekcije { get; set; } = new List<DatumProjekcije>();
        public static Sesija Instance
        {

            get
            {
                if (instance == null)
                    instance = new Sesija();
                return instance;
            }
        }

        public User Korisnik { get; set; }

        private Sesija()
        {
            Korisnik = new User();
        }
    }
}
