using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DevIO.UI.Site.Data.PedidoRepository;

namespace DevIO.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IPedidoRepository _pedidoRepository;
        //public HomeController(IPedidoRepository pedidoRepository)
        //{
        //    _pedidoRepository = pedidoRepository;
        //}
        public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        {
            var pedido = _pedidoRepository.ObterPedido();

            return View(pedido);
        }
    }
}
