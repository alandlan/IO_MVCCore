using DevIO.UI.Site.Models;
using static DevIO.UI.Site.Data.PedidoRepository;

namespace DevIO.UI.Site.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }

        public interface IPedidoRepository
        {
            Pedido ObterPedido();
        }
    }
}
