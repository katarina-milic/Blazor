using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Server.Data;
using Blazor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Server.Controllers
{
    public class RezervacijeController : Controller
    {
        private readonly IRezervacijaRepository rezRepository;
        public RezervacijeController(IRezervacijaRepository rezRepository)
        {
            this.rezRepository = rezRepository;
        }
        // FilmDataAccessLayer objrez = new FilmDataAccessLayer();
        [HttpGet]
        [Route("api/Rezervacija/Index")]
        public IEnumerable<Rezervacija> Index()
        {
            return rezRepository.GetAllR();
        }

        [HttpPost]
        [Route("api/Rezervacija/Create")]
        public void Create([FromBody] RezSedista rezSedista)
        {
            if (ModelState.IsValid)
            {
                rezRepository.AddRezervacija(rezSedista.Rezervacija);
               // rezRepository.AddSedista(rezSedista.Sedista);
            }
        }
        [HttpGet]
        [Route("api/Rezervacija/Details/{id}")]
        public Rezervacija Details(Guid id)
        {
            return rezRepository.GetRezervacija(id);
        }

        [HttpGet]
        [Route("api/Rezervacija/ByFilm/{id}")]
        public List<Rezervacija> RezervacijaById(int id)
        {
            var rezervacije = rezRepository.GetRezervacijaZaFilm(id);
            return rezervacije;
        }

        [HttpPut]
        [Route("api/Rezervacija/Edit")]
        public void Edit([FromBody] Rezervacija rez)
        {
            rezRepository.UpdateRezervacija(rez);
        }
        [HttpDelete]
        [Route("api/Rezervacija/Delete/{id}")]
        public void Delete(Guid id)
        {
            rezRepository.DeleteRezervacija(id);
        }

    }
}