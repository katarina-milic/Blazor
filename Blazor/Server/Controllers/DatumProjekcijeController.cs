using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Server.Data;
using Blazor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Server.Controllers
{
    public class DatumProjekcijeController : Controller
    {
        private readonly IDatumProjekcijeRepository datumRepository;
        public DatumProjekcijeController(IDatumProjekcijeRepository datumRepository)
        {
            this.datumRepository = datumRepository;
        }
        //FilmDataAccessLayer datumRepository = new FilmDataAccessLayer();
        [HttpGet]
        [Route("api/DatumProjekcije/Index")]
        public IEnumerable<DatumProjekcije> Index()
        {
            return datumRepository.GetAllP();
        }

        [HttpPost]
        [Route("api/DatumProjekcije/Create")]
        public void Create([FromBody] DatumProjekcije rez)
        {
            if (ModelState.IsValid)
            {
                datumRepository.AddDatumProjekcije(rez);
            }
        }
        [HttpGet]
        [Route("api/DatumProjekcije/Details/{id}")]
        public DatumProjekcije Details(int id)
        {
            return datumRepository.GetDatumProjekcije(id);
        }
        [HttpPut]
        [Route("api/DatumProjekcije/Edit")]
        public void Edit([FromBody] DatumProjekcije rez)
        {
            datumRepository.UpdateDatumProjekcije(rez);
        }
        [HttpDelete]
        [Route("api/DatumProjekcije/Delete/{id}")]
        public void Delete(int id)
        {
            datumRepository.DeleteDatumProjekcije(id);
        }

    }
}