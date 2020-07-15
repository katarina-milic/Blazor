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
            Filmovi = new FilmRepository(_context);
            Rezervacije = new RezervacijaRepository(_context);
            Projekcije = new DatumProjekcijeRepository(_context);
            Korisnici = new UserRepository(_context);
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

