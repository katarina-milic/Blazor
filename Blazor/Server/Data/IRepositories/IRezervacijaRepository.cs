using Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public interface IRezervacijaRepository : IRepository<Rezervacija>
    {
        IEnumerable<Rezervacija> GetAllR();
        Rezervacija GetRezervacija(Guid id);
        List<Rezervacija> GetRezervacijaZaFilm(int filmId);
        void AddRezervacija(Rezervacija rez);
        void UpdateRezervacija(Rezervacija rez);
        void DeleteRezervacija(Guid id);
    }
}
