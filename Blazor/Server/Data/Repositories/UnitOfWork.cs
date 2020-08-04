using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FilmContext _context;

        public UnitOfWork(FilmContext context)
        {
            _context = context;
            Filmovi = new FilmRepository();
            Rezervacije = new RezervacijaRepository();
            Projekcije = new DatumProjekcijeRepository();
            Korisnici = new UserRepository();
        }
         public IFilmRepository Filmovi { get; private set; }
        public IRezervacijaRepository Rezervacije { get; private set; }
        public IDatumProjekcijeRepository Projekcije { get; private set; }
        public IUserRepository Korisnici { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

