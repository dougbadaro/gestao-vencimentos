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
    public partial class Sobre : Form
    {

        private static Sobre instance;
        public Sobre()
        {
            InitializeComponent();
        }

        public static Sobre GetInstance()
        {

            if ( instance == null || instance.IsDisposed)
            {

                instance = new Sobre();
            }

            return instance;
        }
    }
}
