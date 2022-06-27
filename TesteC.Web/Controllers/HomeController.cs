using Library.Models;
using Library.Services;
using Library.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TesteC.Web.Models;

namespace TesteC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EmpresaService oEmpresaService = new EmpresaService();
        private ProdutoService oProdutoService = new ProdutoService();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Empresa empresa = oEmpresaService.oEmpresaRepository.GetById(1);
            List<Produtos> produtos = oProdutoService.oProdutoRepository.SelecionarTodos().Where(p => p.Destaque == true).ToList();
            List<ImagensProdutos> imagensProdutos = oProdutoService.oProdutoRepository.GetAllImagens().ToList();
            ViewModel viewModel = new ViewModel(empresa, produtos, imagensProdutos);
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
