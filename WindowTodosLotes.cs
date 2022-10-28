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
    public partial class WindowTodosLotes : Form
    {
        private static WindowTodosLotes instance;
        public WindowTodosLotes()
        {
            InitializeComponent();

            dgvTodosLotes.DataSource = BancoDadosSimulado.Compras;

            OcultarColunas();
        }

        public static WindowTodosLotes GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {

                instance = new WindowTodosLotes();
            }

            return instance;
        }

        private void OcultarColunas()
        {

            dgvTodosLotes.Columns[2].Visible = false;
        }
    }
}
