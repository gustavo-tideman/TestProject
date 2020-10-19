using Microsoft.AspNetCore.Mvc;
using System;
using UnitTest.Application.Interface;
using UnitTest.Application.ViewModel;

namespace UnitTest.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clienteService.Adicionar(model);
                    return View();
                }
                return View(model);
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
