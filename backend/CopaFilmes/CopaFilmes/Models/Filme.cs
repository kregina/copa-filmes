using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.Models
{
    public class Filme
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public int Ano { get; set; }

        [Required]
        public float Nota { get; set; }
    }
}
