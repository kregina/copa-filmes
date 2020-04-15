using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Models
{
    public class Eliminatoria
    {
        public IEnumerable<Partida> Partidas { get; private set; }
        public IEnumerable<Filme> Vencedores => Partidas.Select(partida => partida.Vencedor);

        private Eliminatoria(IEnumerable<Partida> partidas)
        {
            Partidas = partidas;
        }

        public static Eliminatoria CriarPrimeiraEliminatoria(IEnumerable<Filme> competidores)
        {
            var partidas = competidores.PrimeiroComUltimo()
                .Select(combinacao => new Partida(combinacao.Primeiro, combinacao.Ultimo));

            return new Eliminatoria(partidas);
        }

        public static Eliminatoria CriarEliminatoriaSubsequente(IEnumerable<Filme> competidores)
        {
            var partidas = competidores.PrimeiroComSegundo()
                .Select(combinacao => new Partida(combinacao.Primeiro, combinacao.Segundo));

            return new Eliminatoria(partidas);
        }

    }
}
