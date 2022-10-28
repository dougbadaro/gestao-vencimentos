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
    public partial class WindowMain : Form
    {
        public WindowMain()
        {
            InitializeComponent();

            new BancoDadosSimulado();

            foreach (Compra compra in BancoDadosSimulado.Compras)
            {
                Console.WriteLine(compra);
            }
        }

        private void mnuTodosLotes_Click(object sender, EventArgs e)
        {

            WindowTodosLotes wtodoslotes = WindowTodosLotes.GetInstance();
            wtodoslotes.MdiParent = this;
            wtodoslotes.WindowState = FormWindowState.Normal;
            wtodoslotes.Show();
        }

        private void aVencerEmAté1DiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WindowVencerUm wvencerum = WindowVencerUm.GetInstance();
            wvencerum.MdiParent = this;
            wvencerum.WindowState = FormWindowState.Normal;
            wvencerum.Show();
        }

        private void aVencerEmAté5DiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WindowVencerCinco wvencercinco = WindowVencerCinco.GetInstance();
            wvencercinco.MdiParent = this;
            wvencercinco.WindowState = FormWindowState.Normal;
            wvencercinco.Show();
        }

        private void vencimentoPersonalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WindowVencerPersonalizado wvencerpersonalizado = WindowVencerPersonalizado.GetInstace();
            wvencerpersonalizado.MdiParent = this;
            wvencerpersonalizado.WindowState = FormWindowState.Normal;
            wvencerpersonalizado.Show();
        }

        private void novoLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WindowNovoLote wnovolote = WindowNovoLote.GetInstance();
            wnovolote.MdiParent = this;
            wnovolote.WindowState = FormWindowState.Normal;
            wnovolote.Show();
        }
    }
}
