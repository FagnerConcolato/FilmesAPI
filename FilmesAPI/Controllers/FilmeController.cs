using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase

    {
        private static List<Filme> Filmes = new List<Filme>();
        [HttpPost]
        public void AdicionalFilme([FromBody]Filme filme)
        {
            Filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);
        }
    }
}
