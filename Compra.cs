using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompras
{
    internal class Compra
    {

        public static Int64 Serial { get; set;  }
        public Int64 Lote { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime Vencimento { get; set; }
        public Int16 Quantidade { get; set; }
        public Decimal Total { get => CalcularTotal(); }

        static Compra()
        {

            Serial = Convert.ToInt64(DateTime.Now.Year.ToString().Substring(2)) * 1000000;
        }

        public Compra()
        {

            Serial += 1;
            Lote = Serial;
        }

        public Compra(Produto produto, DateTime dataCompra, DateTime vencimento, short quantidade) : this()
        {

            Produto = produto;
            DataCompra = dataCompra;
            Vencimento = vencimento;
            Quantidade = quantidade;
        }

        public Decimal CalcularTotal()
        {

            return Quantidade * Produto.Preco;
        }

        public override string ToString()
        {
            return $"{Lote} - {DataCompra:dd/MM/yyyy} - {Vencimento:dd/MM/yyyy} - {Quantidade}";
        }
    }
}
