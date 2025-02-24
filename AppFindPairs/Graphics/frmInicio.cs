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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(145, 214, 172); //Color Pantone 365
            panArriba.BackColor = Color.FromArgb(59, 47, 47); //Color PANTONE 19
            panAbajo.BackColor = Color.FromArgb(59, 47, 47); //Color PANTONE 19
            btnJugar.BackColor = Color.FromArgb(59, 47, 47); //Color PANTONE 19
            btnIntruc.BackColor = Color.FromArgb(59, 47, 47); //Color PANTONE 19
            btnSalir.BackColor = Color.FromArgb(59, 47, 47); //Color PANTONE 19
            panCielo.BackColor = Color.FromArgb(39, 31, 31); //Color PANTONE 19
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJugar frm = new frmJugar();
            frm.Show();
            frmEleccionPares frm2 = new frmEleccionPares();
            frm2.ShowDialog();
        }
    }
}
