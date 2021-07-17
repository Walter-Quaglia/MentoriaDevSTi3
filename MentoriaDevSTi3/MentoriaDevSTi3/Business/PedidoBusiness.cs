using MentoriaDevSti3.Data.Context;
using MentoriaDevSti3.Data.Entidades;
using MentoriaDevSTi3.ViewModel;
using System.Linq;

namespace MentoriaDevSTi3.Business
{
    public class PedidoBusiness
    {
        private readonly MentoriaDevSti3Context _context;

        public PedidoBusiness()
        {
            _context = new MentoriaDevSti3Context();
        }

        public void Adicionar(PedidoViewModel pedidoViewModel)
        {
            _context.Pedidos.Add(new Pedido
            {
                ClienteId = pedidoViewModel.ClienteId,
                FormaPagamento = pedidoViewModel.FormaPagamento,
                Valor = pedidoViewModel.Valor,
                ItensPedido = pedidoViewModel.ItensPedidoViewModel.Select(s => new ItemPedido
                {
                    ProdutoId = s.ProdutoId,
                    Quantidade = s.Quantidade,
                    Valor = s.Valor,
                }).ToList()
            });

            _context.SaveChanges();
        }
    }
}
