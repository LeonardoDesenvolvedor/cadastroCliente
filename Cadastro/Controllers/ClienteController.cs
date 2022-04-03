
using Cadastro.Data;
using Microsoft.AspNetCore.Mvc;



namespace Cadastro.Controllers
{

    public class ClienteController : Controller
    {
        private readonly AppCont _appCont;
            public ClienteController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allTasks = _appCont.Clientes.ToList();
            return View(allTasks);
        }

    }

}