using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IFilmRepository Filmovi { get; }
        IRezervacijaRepository Rezervacije { get; }
        IDatumProjekcijeRepository Projekcije { get; }
        IUserRepository Korisnici { get; }
        int Complete();
        
    }
}
