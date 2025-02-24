using AppFindPairs.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFindPairs.Graphics
{
    public partial class frmJugar : Form
    {
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private int CantidadPares = 10;
        public frmJugar()
        {
            InitializeComponent();
        }

        private void frmJugar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(145, 214, 172); //Color Pantone 365
            panArriba.BackColor = Color.FromArgb(59, 47, 47); //Color PANTONE 19
            panCielo.BackColor = Color.FromArgb(39, 31, 31); //Color PANTONE 19

            InicializarPictureBoxes();
        }

        private void InicializarPictureBoxes()
        {
            pictureBoxes = new List<PictureBox>
            {
                picBox1, picBox2, picBox3, picBox4, picBox5,
                picBox6, picBox7, picBox8, picBox9, picBox10,
                picBox11, picBox12, picBox13, picBox14, picBox15,
                picBox16, picBox17, picBox18, picBox19, picBox20,
                picBox21, picBox22, picBox23, picBox24
            };

            foreach (var picBox in pictureBoxes)
            {
                picBox.BackColor = Color.FromArgb(115, 184, 142);
                picBox.Hide();
            }

            MostrarPicBox();
        }

        private void MostrarPicBox()
        {
            List<string> listaCartasElegidas = CartasElegidas.GetCartas(CantidadPares);
            for (int i = 0; i < listaCartasElegidas.Count; i++)
            {
                foreach (var picBox in pictureBoxes)
                {
                    if (picBox.Name.Equals(listaCartasElegidas[i]))
                    { 
                        picBox.Show();
                        break;
                    }
                }
            }
        }

        private void frmJugar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
