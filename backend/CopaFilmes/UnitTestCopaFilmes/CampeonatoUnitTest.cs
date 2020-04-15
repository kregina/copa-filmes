using CopaFilmes.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace UnitTestCopaFilmes
{
    [TestClass]
    public class UnitTestCampeonato
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            //Arange
            var titulosSelecionados = new[] {
                 "Os Incr�veis 2"
                ,"Jurassic World: Reino Amea�ado"
                ,"Oito Mulheres e um Segredo"
                ,"Heredit�rio"
                ,"Vingadores: Guerra Infinita"
                ,"Deadpool 2"
                ,"Han Solo: Uma Hist�ria Star Wars"
                ,"Thor: Ragnarok"
            };

            var competidoresEsperados = new[]
            {
                 "Deadpool 2"
                ,"Han Solo: Uma Hist�ria Star Wars"
                ,"Heredit�rio"
                ,"Jurassic World: Reino Amea�ado"
                ,"Oito Mulheres e um Segredo"
                ,"Os Incr�veis 2"
                ,"Thor: Ragnarok"
                ,"Vingadores: Guerra Infinita"
            };

            var titulosVencedoresEsperados = new[]
            {
                new[] {"Vingadores: Guerra Infinita", "Thor: Ragnarok", "Os Incr�veis 2", "Jurassic World: Reino Amea�ado"},
                new[] {"Vingadores: Guerra Infinita", "Os Incr�veis 2"},
                new[] {"Vingadores: Guerra Infinita"}
            };

            var titulosVencedoresResultadoFInalEsperado = new[] { "Vingadores: Guerra Infinita", "Os Incr�veis 2" };

            List<Filme> filmes;
            using (FileStream fs = File.OpenRead("filmes.json"))
            {
                filmes = await JsonSerializer.DeserializeAsync<List<Filme>>(fs,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }

            var filmesSelecionados = titulosSelecionados
                .Select(titulo => filmes.Find(f => f.Titulo == titulo));

            //Act
            var campeonato = new Campeonato(filmesSelecionados);

            var eliminatorias = campeonato.Eliminatorias();
            var titulosVencedores = eliminatorias.Select(e => e.Vencedores.Select(f => f.Titulo)).ToList();

            var resultadoFinal = campeonato.ResultadoFinal();
            var titulosVencedoresResultadoFInal = resultadoFinal.Select(f => f.Titulo).ToList();

            //Assert
            CollectionAssert.AreEqual(competidoresEsperados, campeonato.Competidores.Select(c => c.Titulo).ToList());

            titulosVencedores
                .Zip(titulosVencedoresEsperados, (atual, esperado) => (atual, esperado))
                .ToList()
                .ForEach(elminatoria =>
                {
                    CollectionAssert.AreEqual(elminatoria.esperado, elminatoria.atual.ToList());
                });

            CollectionAssert.AreEqual(titulosVencedoresResultadoFInalEsperado, titulosVencedoresResultadoFInal);
        }
    }
}
