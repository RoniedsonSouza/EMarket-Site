using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteC.Web.Controllers
{
    public class ServicosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
