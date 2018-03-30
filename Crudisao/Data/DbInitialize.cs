using Crudisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crudisao.Data
{
    public class DbInitialize
    {
        public static void Initialize(LojaContext context)

        {
            context.Database.EnsureCreated();

            // Look for any students.

            if (context.Produtos.Any())
            {
                return;
            }

            var usuario = new Usuario { Nome = "Mandioca", Email = "naoteinteressa@du", Cpf = "70707070" };
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            var prod1 = new Produto { Nome = "KiProduto", Preco = 3000 };
            var prod2 = new Produto { Nome = "KiProdut3", Preco = 2000 };
            var prod3 = new Produto { Nome = "KiProdut2", Preco = 1000 };
            var produtos = new[] { prod1, prod2, prod3 };
            context.Produtos.AddRange(produtos);
            context.SaveChanges();

            var pedido = new Pedido { UsuarioId = usuario.ID, Data = DateTime.Now };
            context.Pedidos.Add(pedido);
            context.SaveChanges();

            var produtosComprados = new List<Produto> { prod1, prod3 };

            foreach (var prod in produtosComprados)
            {
                var pedidoItem = new PedidoItem { PedidoId = pedido.ID, ProdutoId = prod.ID };
                context.PedidosItens.Add(pedidoItem);
                context.SaveChanges();
            }
        }
    }
}
