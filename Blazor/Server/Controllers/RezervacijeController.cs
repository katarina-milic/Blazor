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
        FilmDataAccessLayer objrez = new FilmDataAccessLayer();
        [HttpGet]
        [Route("api/Rezervacija/Index")]
        public IEnumerable<Rezervacija> Index()
        {
            return objrez.GetAllR();
        }

        [HttpPost]
        [Route("api/Rezervacija/Create")]
        public void Create([FromBody] Rezervacija rez)
        {
            if (ModelState.IsValid)
            {
                objrez.AddRezervacija(rez);
            }
        }
        [HttpGet]
        [Route("api/Rezervacija/Details/{id}")]
        public Rezervacija Details(int id)
        {
            return objrez.GetRezervacija(id);
        }

        [HttpGet]
        [Route("api/Rezervacija/ByFilm/{id}")]
        public List<Rezervacija> RezervacijaById(int id)
        {
            return objrez.GetRezervacijaZaFilm(id);
        }

        [HttpPut]
        [Route("api/Rezervacija/Edit")]
        public void Edit([FromBody] Rezervacija rez)
        {
            objrez.UpdateRezervacija(rez);
        }
        [HttpDelete]
        [Route("api/Rezervacija/Delete/{id}")]
        public void Delete(int id)
        {
            objrez.DeleteRezervacija(id);
        }

    }
}