using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCompras
{
    internal class BancoDadosSimulado
    {

        public static List<Produto> Produtos { get; set; }
        public static List<Compra> Compras { get; set; }

        public BancoDadosSimulado()
        {

            Produtos = new List<Produto>();
            Produtos.Add(new Produto(2200001, "Computer", 4560.57m));
            Produtos.Add(new Produto(2200002, "LapTop", 4560.57m));
            Produtos.Add(new Produto(2200003, "TV", 4560.57m));
            Produtos.Add(new Produto(2200004, "Bike", 4560.57m));

            Compras = new List<Compra>();
        }

        public static List<Compra> PesquisaCompra(Double dias)
        {

            List<Compra> PesquisaCompra = new List<Compra>();

            foreach (Compra compra in BancoDadosSimulado.Compras)
            {

                if ((compra.Vencimento - DateTime.Now).Days <= dias)
                {

                    PesquisaCompra.Add(compra);
                }
            }

            return PesquisaCompra;
        }

        public static List<Compra> PesquisaCompraPersonalizada(DateTime selecteddataprimary, DateTime selecteddatasecundary)
        {

            List<Compra> PesquisaCompra = new List<Compra>();

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
