using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex002
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private async void btnInicio_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "MEU BRASIL BRASILEIRO";
            lblMsg.Visible = true;

            await Task.Delay(2000);
            lblMsg.Text = "MEU";
            lblMsg.ForeColor = Color.White;
            lblMsg.BackColor = Color.Blue;

            await Task.Delay(2000);
            lblSegundo.Text = "BRASIL";
            lblSegundo.Visible = true;
            lblSegundo.ForeColor = Color.Green;
            lblSegundo.BackColor = Color.Yellow;
            await Task.Delay(2000);
            lblTerceiro.Text ="BRASILEIRO";
            lblTerceiro.Visible = true;
            lblTerceiro.ForeColor = Color.Yellow;
            lblTerceiro.BackColor = Color.Green;


        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
            

        }
    }
}
