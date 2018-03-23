using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudisao.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public string Nome { get; set; }
    }
}
