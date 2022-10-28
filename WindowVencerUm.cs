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
    public partial class WindowVencerUm : Form
    {

        private static WindowVencerUm instance;
        public WindowVencerUm()
        {
            InitializeComponent();
        }

        public static WindowVencerUm GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {

                instance = new WindowVencerUm();
            }

            return instance;
        }

        private void WindowVencerUm_Load(object sender, EventArgs e)
        {

            dgvVencerUm.DataSource = BancoDadosSimulado.PesquisaCompra(1);

            OcultarColunas();
        }

        private void OcultarColunas()
        {

            dgvVencerUm.Columns[2].Visible = false;
        }
    }
}
