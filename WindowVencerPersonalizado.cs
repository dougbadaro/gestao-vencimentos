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
    public partial class WindowVencerPersonalizado : Form
    {

        private static WindowVencerPersonalizado instance;
        public WindowVencerPersonalizado()
        {
            InitializeComponent();
        }

        public static WindowVencerPersonalizado GetInstace()
        {

            if (instance == null || instance.IsDisposed)
            {

                instance = new WindowVencerPersonalizado();
            }

            return instance;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            dgvPersonalizado.DataSource = BancoDadosSimulado.PesquisaCompraPersonalizada(dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
