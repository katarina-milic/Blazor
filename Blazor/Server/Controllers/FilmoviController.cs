﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Server.Data;
using Blazor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Server.Controllers
{
    public class FilmoviController : Controller

    {
        private readonly FilmRepository filmRepository;
        public FilmoviController()
        {
            this.filmRepository = new FilmRepository();
        }
      //  FilmDataAccessLayer objfilm = new FilmDataAccessLayer();
        [HttpGet]
        [Route("api/Film/Index")]
        public IEnumerable<Film> Index()
        {
            return filmRepository.GetAllFilms();
        }

        [HttpPost]
        [Route("api/Film/Create")]
        public void Create([FromBody] Film film)
        {
            if(ModelState.IsValid)
            {
                filmRepository.AddFilm(film);
            }
        }
        [HttpGet]
        [Route("api/Film/Details/{id}")]
        public Film Details (int id)
        {
            return filmRepository.GetFilm(id);
        }
        [HttpPut]
        [Route("api/Film/Edit")]
        public void Edit([FromBody] Film film)
        {
            filmRepository.UpdateFilm(film);
        }
        [HttpDelete]
        [Route("api/Film/Delete/{id}")]
        public void Delete(int id)
        {
            filmRepository.DeleteFilm(id);
        }
     
    }
}