using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08D
{
    public partial class btnMaximizar : Form
    {
        public btnMaximizar()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaxim_Click(object sender, EventArgs e)
        {
            btnmaxim.Visible = false;
            btnmaxim.Visible = true;

        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnmini.Visible = false;
            btnmini.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox.Text); 
            int dobro = numero * 2;
            lblMsg.Text = ("O dobro de " + numero + " é " + dobro);
            lblMsg.Visible = true;
        }
    }
}
