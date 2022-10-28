using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCompras
{
    public partial class WindowNovoLote : Form
    {

        private static WindowNovoLote instance;
        private Compra compraaux;
        public WindowNovoLote()
        {
            InitializeComponent();

            compraaux = new Compra();

            //lblLote.Text = $"{compraaux.Lote}";
            comboBox1.DataSource = BancoDadosSimulado.Produtos;
        }

        public static WindowNovoLote GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {

                instance = new WindowNovoLote();
            }

            return instance;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Compra compra = new Compra(dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt16(nudQuantidade.Value));

            BancoDadosSimulado.Compras.Add(compra);
        }
    }
}
