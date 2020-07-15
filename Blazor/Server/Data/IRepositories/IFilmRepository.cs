using Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public interface IFilmRepository : IRepository<Film>
    {
        IEnumerable<Film> GetAllFilms();
        Film GetFilm(int id);
        void AddFilm(Film film);
        void UpdateFilm(Film film);
        void DeleteFilm(int id);
    }
}
