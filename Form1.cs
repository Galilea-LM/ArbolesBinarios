using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4_ArbolesBinarios
{
    public partial class Form1 : Form
    {
        ArbolBinario arbol = new ArbolBinario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            int informacion = Convert.ToInt32(txtInfoNodo.Text);
            arbol.Insertar(informacion);
        }

        private void btnBuscarNodo_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenarPreOrden_Click(object sender, EventArgs e)
        {
            arbol.PreOrden();
        }

        private void btnOrdenarInOrden_Click(object sender, EventArgs e)
        {
            arbol.InOrden(); 
        }

        private void btnOrdenarPosOrden_Click(object sender, EventArgs e)
        {
            arbol.PosOrden();
        }
    }
}
