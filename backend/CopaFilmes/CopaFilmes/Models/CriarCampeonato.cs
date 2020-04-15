using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CopaFilmes.Models
{
    public class CriarCampeonato
    {
        [MinLength(8)]
        [MaxLength(8)]
        public IEnumerable<Filme> Filmes { get; set; }
    }
}
