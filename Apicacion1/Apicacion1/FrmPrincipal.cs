using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apicacion1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            FrmColores colores = new FrmColores();
            colores.Show();
        }

        private void mnuColores_Click(object sender, EventArgs e)
        {
            FrmColores colores = new FrmColores();
            colores.MdiParent = this;
            colores.Visible = true;
        }

        private void mnuOperacionesBasicas_Click(object sender, EventArgs e)
        {
            FrmOperacionesBasicas ob = new FrmOperacionesBasicas();
            ob.MdiParent = this;
            ob.Visible = true;

        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            FrmClientes cl = new FrmClientes();
            cl.MdiParent = this;
            cl.Visible = true;

        }

        private void tablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablas frmTablas = new FrmTablas();
            frmTablas.MdiParent = this;
            frmTablas.Visible = true;

        }

        private void mnuPromedio_Click(object sender, EventArgs e)
        {
            FrmNotas frmNotas = new FrmNotas();
            frmNotas.MdiParent = this;
            frmNotas.Visible = true;
        }
    }
}
