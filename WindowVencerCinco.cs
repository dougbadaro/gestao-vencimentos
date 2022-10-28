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
    public partial class WindowVencerCinco : Form
    {

        private static WindowVencerCinco instance;
        public WindowVencerCinco()
        {
            InitializeComponent();
        }

        public static WindowVencerCinco GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {

                instance = new WindowVencerCinco();
            }

            return instance;
        }

        private void WindowVencerCinco_Load(object sender, EventArgs e)
        {

            dgvCincoDias.DataSource = BancoDadosSimulado.PesquisaCompra(5);
        }
    }
}
