using Microsoft.AspNetCore.Mvc;
using NunesSports.Models;
using NunesSports.Repositorio;
using System.Diagnostics;

namespace NunesSports.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepositorio _IProdutoRepositorio;
        public HomeController(IProdutoRepositorio produtoRepositorio)
        {
            _IProdutoRepositorio = produtoRepositorio;
        }

        public IActionResult Index()
        {
            List<Produto> produto = _IProdutoRepositorio.BuscarTodos();
            return View(produto);
        }

       

        
    }
}
