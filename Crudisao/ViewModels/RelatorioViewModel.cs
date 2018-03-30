using Crudisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudisao.ViewModels
{
    public class RelatorioViewModel
    {
        public RelatorioViewModel(List<Pedido> pedidos)
        {
            TotalPedidos = pedidos.Count;
            var produtos = pedidos.SelectMany(p => p.Itens.Select(i => i.Produto.ID)).Distinct();
            RelatorioProdutos = pedidos.
        }
        public double TotalMensal { get; set; }
        public int TotalProduto { get; set; }
        public int TotalPedidos { get; set; }

        public List<RelatorioProdutoViewModel> RelatorioProdutos { get; set; }
    }

    public class RelatorioProdutoViewModel
    {
        public double TotalMensal { get; set; }
        public int TotalProduto { get; set; }
        public int TotalPedidos { get; set; }
        public Produto Produto { get; set; }
    }
}
