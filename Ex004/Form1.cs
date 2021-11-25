using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            float numero = 0;
            float.TryParse(txtBox.Text, out numero);

            float n1 = (int)numero;
            int n2 = Convert.ToInt16(numero);

            label2.Text = $" Você digitou o valor: {numero:F3}";
            label3.Text = $" A parte inteiro do número é: {n1}";
            label4.Text = $" Arredondando,temos o número: {n2}";

        }
    }
}
