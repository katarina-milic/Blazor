using Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public interface IDatumProjekcijeRepository : IRepository<DatumProjekcije>
    {
        IEnumerable<DatumProjekcije> GetAllP();
        DatumProjekcije GetDatumProjekcije(int id);
        void AddDatumProjekcije(DatumProjekcije datum);
        void UpdateDatumProjekcije(DatumProjekcije datum);
        void DeleteDatumProjekcije(int id);
    }
}
