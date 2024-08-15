using Microsoft.AspNetCore.Mvc;
using NunesSports.Models;
using NunesSports.Repositorio;

namespace NunesSports.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _IProdutoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _IProdutoRepositorio = produtoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            Produto produto =_IProdutoRepositorio.ListarPorId(id);
            return View(produto);
        }

        public IActionResult Apagar(int id)
        {
            Produto produto = _IProdutoRepositorio.ListarPorId(id);
            return View(produto);
        }

        //------

        public IActionResult Deletar(int id) 
        {
            _IProdutoRepositorio.Apagar(id);

            return RedirectToAction("Index", "Home");
        
        
        }


        
        [HttpPost]
        public IActionResult Criar(Produto produto)
        {
            _IProdutoRepositorio.Adicionar(produto);

            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public IActionResult Alterar(Produto produto)
        {
            _IProdutoRepositorio.Atualizar(produto);

            return RedirectToAction("Index", "Home");
        }
        



    }
}
