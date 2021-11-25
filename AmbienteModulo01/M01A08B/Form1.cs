using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lblMsg.Text = "Muito prazer em te conhecer, " + nome + "!";
            lblMsg.Visible = true;
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
          
           
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ForeColor = Color.BlueViolet;
            BackColor = Color.AntiqueWhite;

        }
    }
}
