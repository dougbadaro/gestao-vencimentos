using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCompras
{
    internal class BancoDadosSimulado
    {

        public static List<Produto> Produtos { get; set; }
        public static BindingList<Compra> Compras { get; set; }

        public BancoDadosSimulado()
        {

            Produtos = new List<Produto>();
            Produtos.Add(new Produto(0, "Selecione o produto", 0));
            Produtos.Add(new Produto(1, "Abobora", 12.20m));
            Produtos.Add(new Produto(2, "Abacaxi", 20.00m));
            Produtos.Add(new Produto(3, "Abacate", 30.00m));
            Produtos.Add(new Produto(4, "Banana", 40.00m));
            Produtos.Add(new Produto(5, "Caju", 50.00m));
            Produtos.Add(new Produto(6, "Cajá", 60.00m));
            Produtos.Add(new Produto(7, "Damasco", 70.00m));
            Produtos.Add(new Produto(8, "Ervilha", 80.00m));
            Produtos.Add(new Produto(9, "Framboesa", 90.00m));
            Produtos.Add(new Produto(10, "Goiaba", 100.00m));

            Compras = new BindingList<Compra>();
        }

        public static BindingList<Compra> PesquisaCompra(Double dias)
        {

            BindingList<Compra> PesquisaCompra = new BindingList<Compra>();

            foreach (Compra compra in BancoDadosSimulado.Compras)
            {

                if ((compra.Vencimento - DateTime.Now).Days <= dias)
                {

                    PesquisaCompra.Add(compra);
                }
            }

            return PesquisaCompra;
        }

        public static BindingList<Compra> PesquisaCompraPersonalizada(DateTime selecteddataprimary, DateTime selecteddatasecundary)
        {

            BindingList<Compra> PesquisaCompra = new BindingList<Compra>();

            foreach (Compra compra in BancoDadosSimulado.Compras)
            {

                if (compra.Vencimento >= selecteddataprimary && compra.Vencimento <= selecteddatasecundary)
                {

                    PesquisaCompra.Add(compra);
                }
            }

            return PesquisaCompra;
        }
    }
} 
