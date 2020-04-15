using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.Models
{
    public class Partida
    {
        public IEnumerable<Filme> Resultado { get; private set; }
        public Filme Vencedor => Resultado.First();
        public Partida(params Filme[] filmes)
        {
            Resultado = filmes
                .OrderByDescending(f => f.Nota)
                .ThenBy(f => f.Titulo);
        }
    }
}
