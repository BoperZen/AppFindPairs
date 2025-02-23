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
    public partial class frmJugar : Form
    {
        public frmJugar()
        {
            InitializeComponent();
        }

        private void frmJugar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(145, 214, 172); //Color Pantone 365
        }

        private void frmJugar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
