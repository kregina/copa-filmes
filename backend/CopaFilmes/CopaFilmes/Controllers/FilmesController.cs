using CopaFilmes.Models;
using CopaFilmes.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaFilmes.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly CopaFilmesApiService _service;

        public FilmesController(CopaFilmesApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Filme>> GetAsync()
        {
            return await _service.GetFilmes();
        }
    }
}
