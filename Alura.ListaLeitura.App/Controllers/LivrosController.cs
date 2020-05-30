using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Alura.ListaLeitura.App.Controllers
{
    public class LivrosController : Controller
    {
        public List<Livro> Livros { get; set; }

        public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.FirstOrDefault(l => l.Id == id);

            if (livro == null)
            {
                return "Livro não encontrado";
            }

            return livro.Detalhes();
        }
        public IActionResult ParaLer()
        {
            var repo = new LivroRepositorioCSV();
            ViewBag.Livros = repo.ParaLer.Livros;

            return View("lista");
        }
        public IActionResult Lidos()
        {
            var repo = new LivroRepositorioCSV();
            ViewBag.Livros = repo.Lidos.Livros;

            return View("lista");
        }
        public IActionResult Lendo()
        {
            var repo = new LivroRepositorioCSV();
            ViewBag.Livros = repo.Lendo.Livros;

            return View("lista");
        }

        public string Teste()
        {
            return "Testando o roteamento do framework mvc";
        }

    }
}
