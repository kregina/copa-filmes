using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Models
{
    public static class ChaveamentoExtensions
    {
        public static IEnumerable<(T Primeiro, T Ultimo)> PrimeiroComUltimo<T>(this IEnumerable<T> items)
        {
            var quantidadeItems = items.Count();

            if (quantidadeItems % 2 != 0)
            {
                throw new ArgumentException("A quantidade de itens deve ser um número par.");
            }

            var quantidadeCombinacoes = quantidadeItems / 2;

            var chaveA = Enumerable.Range(0, quantidadeCombinacoes);
            var chaveB = chaveA.Select(i => quantidadeItems - i - 1);

            var itensChaveA = chaveA.Select(i => items.ElementAt(i));
            var itensChaveB = chaveB.Select(i => items.ElementAt(i));

            return itensChaveA.Zip(itensChaveB);
        }

        public static IEnumerable<(T Primeiro, T Segundo)> PrimeiroComSegundo<T>(this IEnumerable<T> itens)
        {
            var quantidadeItems = itens.Count();

            if (quantidadeItems % 2 != 0)
            {
                throw new ArgumentException("A quantidade de itens deve ser um número par.");
            }

            var quantidadeCombinacoes = quantidadeItems / 2;

            var chaveA = Enumerable.Range(0, quantidadeCombinacoes).Select(i => i * 2);
            var chaveB = chaveA.Select(i => i + 1);

            var itensChaveA = chaveA.Select(i => itens.ElementAt(i));
            var itensChaveB = chaveB.Select(i => itens.ElementAt(i));

            return itensChaveA.Zip(itensChaveB);
        }
    }
}
