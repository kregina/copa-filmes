using CopaFilmes.Models;
using CopaFilmes.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly CopaFilmesApiService _service;

        public FilmesController(CopaFilmesApiService service) 
        {
            _service = service;
        }

        // GET: api/Filmes
        [HttpGet]
        public async Task<IEnumerable<Filme>> GetAsync()
        {
            return await _service.GetFilmes();
        }
    }
}
