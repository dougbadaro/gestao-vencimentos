using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompras
{
    internal class Produto
    {

        public Int64 Codigo { get; set; }

        private String _nome;
        public String Nome
        {
            get { return _nome; }
            set
            {
                if (value.Length > 45)
                {
                    _nome = value.Substring(0, 45);
                }
                else
                {
                    _nome = value;
                }
            }
        }
        public Decimal Preco { get; set; }

        public Produto()
        {
        }

        public Produto(Int64 codigo, String nome, Decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
