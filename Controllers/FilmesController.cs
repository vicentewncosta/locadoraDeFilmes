using locadora.Models;
using locadora.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace locadora.Controllers
{
    public class FilmeRepositorio : Controller
    {
        private readonly IFilmeRepositorio _filmeRepositorio; 

        public FilmeRepositorio(IFilmeRepositorio filmeRepositorio)
        {
            _filmeRepositorio = filmeRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(FilmeModel filme)
        {
            _filmeRepositorio.Adicionar(filme);
            return RedirectToAction("Index");
        }
    }
}
