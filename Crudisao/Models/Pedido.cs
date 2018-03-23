using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudisao.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        public int? UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime Data { get; set; }
        public ICollection<PedidoItem> Itens { get; set; }
    }
}
