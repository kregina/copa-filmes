using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Models
{
    public class Campeonato
    {
        public IEnumerable<Filme> Competidores { get; private set; }
        public Campeonato(IEnumerable<Filme> filmes)
        {
            Competidores = filmes.OrderBy(f => f.Titulo);
        }

        public Partida Final() => Eliminatorias().Last().Partidas.First();

        public IEnumerable<Filme> ResultadoFinal() => Final().Resultado;

        public IEnumerable<Eliminatoria> Eliminatorias()
        {
            var eliminatoria = Eliminatoria.CriarPrimeiraEliminatoria(Competidores);

            yield return eliminatoria;

            while (eliminatoria.Partidas.Count() > 1)
            {
                eliminatoria = Eliminatoria.CriarEliminatoriaSubsequente(eliminatoria.Vencedores);

                yield return eliminatoria;
            }
        }
    }
}
