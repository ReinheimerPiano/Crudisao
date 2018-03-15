using System;
using System.Collections.Generic;

namespace Crudisao.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public Pedido Pedidos { get; set; }
    }
}
