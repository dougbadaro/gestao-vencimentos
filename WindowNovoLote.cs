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
        public WindowNovoLote()
        {
            InitializeComponent();

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

            Compra compra = new Compra((Produto) comboBox1.SelectedItem, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, Convert.ToInt16(nudQuantidade.Value));

            BancoDadosSimulado.Compras.Add(compra);
            comboBox1.SelectedIndex = 0;
            nudQuantidade.Value = 1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void HabilitarBotao()
        {

            if (nudQuantidade.Value > 0 && comboBox1.SelectedIndex > 0)
            {

                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

            nudQuantidade.Maximum = 100;

            HabilitarBotao();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            HabilitarBotao();
        }
    }
}
