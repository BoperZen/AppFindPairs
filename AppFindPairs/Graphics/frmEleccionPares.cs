using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFindPairs.Graphics
{
    public partial class frmEleccionPares : Form
    {
        public frmEleccionPares()
        {
            InitializeComponent();
        }

        private void frmEleccionPares_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(115, 184, 142); //Color Pantone 365
            panConfig.BackColor = Color.FromArgb(145, 214, 172);
            label1.ForeColor = Color.FromArgb(59, 47, 47);
            btnIniciar.BackColor = Color.FromArgb(59, 47, 47);

            InicializarCombo();
        }

        private void InicializarCombo()
        {
            cmbCantidad.ForeColor = Color.FromArgb(59, 47, 47);
            cmbCantidad.Items.Clear();
            cmbCantidad.Items.Add("Jugar con 4 pares");
            cmbCantidad.Items.Add("Jugar con 5 pares");
            cmbCantidad.Items.Add("Jugar con 6 pares");
            cmbCantidad.Items.Add("Jugar con 7 pares");
            cmbCantidad.Items.Add("Jugar con 8 pares");
            cmbCantidad.Items.Add("Jugar con 9 pares");
            cmbCantidad.Items.Add("Jugar con 10 pares");
            cmbCantidad.Items.Add("Jugar con 11 pares");
            cmbCantidad.Items.Add("Jugar con 12 pares");
        }

        private void frmEleccionPares_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            //Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
