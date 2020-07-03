using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Server.Data;
using Blazor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Server.Controllers
{
    public class SedistaController : Controller
    {
        FilmDataAccessLayer objSed = new FilmDataAccessLayer();

        [HttpPost]
        [Route("api/Sedista/Populate")]
        public void Create([FromBody] List<Sediste> sedista)
        {
            if (ModelState.IsValid)
            {
                objSed.AddSedista(sedista);
            }
        }
    }
}