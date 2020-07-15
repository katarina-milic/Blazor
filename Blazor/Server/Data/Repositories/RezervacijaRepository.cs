using Blazor.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class RezervacijaRepository : Repository<Rezervacija>, IRezervacijaRepository
    {
        private readonly FilmContext rezContext;

        public RezervacijaRepository(FilmContext rezContext) : base(rezContext)
        {
            

        }
        public IEnumerable<Rezervacija> GetAllR()
        {
            return rezContext.Rezervacije.Include(item => item.User).Include(item => item.Film).Include(item => item.Datum).ToList();

        }
        public Rezervacija GetRezervacija(Guid id)
        {
            var rez = rezContext.Rezervacije.Find(id);
            return rez;
        }

        public List<Rezervacija> GetRezervacijaZaFilm(int filmId)
        {
            var rezervacije = rezContext.Rezervacije.Where(item => item.Film.Id == filmId).Include(item => item.Datum).Include(item => item.Sediste).ToList();
            return rezervacije;
        }

        public void AddRezervacija(Rezervacija rez)
        {
            rezContext.Entry(rez).State = EntityState.Modified;
            rezContext.Rezervacije.Add(rez);
            rezContext.SaveChanges();
        }
        public void UpdateRezervacija(Rezervacija rez)
        {
            rezContext.Entry(rez).State = EntityState.Modified;
            rezContext.SaveChanges();

        }
        public void DeleteRezervacija(Guid id)
        {
            var rez = rezContext.Rezervacije.Find(id);
            rezContext.Rezervacije.Remove(rez);
            rezContext.SaveChanges();
        }
        public FilmContext FilmContext
        {
            get { return Context as FilmContext; }
        }

    }
}
