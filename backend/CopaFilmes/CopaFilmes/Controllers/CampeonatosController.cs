using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaFilmes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampeonatosController : ControllerBase
    {
        // POST: api/Campeonatos
        [HttpPost]
        public IEnumerable<Filme> Post(CriarCampeonato comando)
        {
            var campeonato = new Campeonato(comando.Filmes);
            return campeonato.ResultadoFinal();
        }
    }
}
