using Blazor.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class DatumProjekcijeRepository : Repository<DatumProjekcije>, IDatumProjekcijeRepository
    {
        private readonly FilmContext datumContext;
        public DatumProjekcijeRepository(FilmContext datumContext) : base(datumContext)
        {
//this.datumContext = datumContext;

        }

        public IEnumerable<DatumProjekcije> GetAllP()
        {
            return datumContext.Projekcije.ToList();

        }
        public DatumProjekcije GetDatumProjekcije(int id)
        {
            var pro = datumContext.Projekcije.Find(id);
            return pro;
        }
        public void AddDatumProjekcije(DatumProjekcije pro)
        {
            datumContext.Projekcije.Add(pro);
            datumContext.SaveChanges();
        }
        public void UpdateDatumProjekcije(DatumProjekcije pro)
        {
            datumContext.Entry(pro).State = EntityState.Modified;
            datumContext.SaveChanges();

        }
        public void DeleteDatumProjekcije(int id)
        {
            var pro = datumContext.Projekcije.Find(id);
            datumContext.Projekcije.Remove(pro);
            datumContext.SaveChanges();
        }
        public FilmContext FilmContext
        {
            get { return Context as FilmContext; }
        }
    }
    }

