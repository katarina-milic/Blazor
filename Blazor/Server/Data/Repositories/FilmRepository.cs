using Blazor.Shared;
using Microsoft.EntityFrameworkCore;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class FilmRepository : Repository<Film>, IFilmRepository

    {
        private readonly FilmContext filmContext;

        public FilmRepository() : base()
        {
            filmContext = new FilmContext();
        }
        public IEnumerable<Film> GetAllFilms()
        {
            return filmContext.Filmovi.ToList();

        }
        public Film GetFilm(int id)
        {
            var film = filmContext.Filmovi.Include(f => f.Projekcije).Single(x => x.Id == id);
            return film;
        }
        public void AddFilm(Film film)
        {
            filmContext.Filmovi.Add(film);
            filmContext.SaveChanges();
        }
        public void UpdateFilm(Film film)
        {
            filmContext.Entry(film).State = EntityState.Modified;
            filmContext.SaveChanges();

        }
        public void DeleteFilm(int id)
        {
            var film = filmContext.Filmovi.Find(id);
            filmContext.Filmovi.Remove(film);
            filmContext.SaveChanges();
        }
        public FilmContext FilmContext
        {
            get { return Context as FilmContext; }
        }
    }
}