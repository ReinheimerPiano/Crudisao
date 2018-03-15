using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudisao.Models
{
    public class PedidoItem
    {
        public int ProdutoId { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
    }
}
