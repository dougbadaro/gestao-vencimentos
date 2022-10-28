using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompras
{
    internal class Compra
    {

        public static Int64 Lote { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime Vencimento { get; set; }
        public Int16 Quantidade { get; set; }

        static Compra()
        {

            Lote = Convert.ToInt64(DateTime.Now.Year.ToString().Substring(2)) * 1000000;
        }

        public Compra()
        {

            Lote += 1;
        }

        public Compra(DateTime dataCompra, DateTime vencimento, short quantidade) : this()
        {

            DataCompra = dataCompra;
            Vencimento = vencimento;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"{Lote} - {DataCompra:dd/MM/yyyy} - {Vencimento:dd/MM/yyyy} - {Quantidade}";
        }
    }
}
