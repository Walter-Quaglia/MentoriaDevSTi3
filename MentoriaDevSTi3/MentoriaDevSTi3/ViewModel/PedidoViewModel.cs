using System;
using System.Collections.Generic;
using System.Text;

namespace MentoriaDevSTi3.ViewModel
{
    public class PedidoViewModel
    {
        public string FormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public long ClienteId { get; set; }

        public List<ItensPedidoViewModel> ItensPedido { get; set; }
    }
}
