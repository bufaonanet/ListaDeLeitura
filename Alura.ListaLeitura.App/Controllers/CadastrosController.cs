using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Controllers
{
    public class CadastrosController : Controller
    {
        public string Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);

            return "Livro adicionado!";
        }
        public IActionResult ExibeFormulario()
        {          
            return View("formulario");
        }

    }
}
