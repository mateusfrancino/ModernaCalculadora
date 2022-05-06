using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernaCalculadora
{
    public partial class frmCalculadora : Form
    {
        int v1;
        int v2;
        int soma;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void pcSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblValor1.Visible = false;
            lblValor2.Visible = false;
            lblSinal.Visible = false;
        }

        private void lblZerar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblValor1.Visible = false;
            lblValor2.Visible = false;
            lblSinal.Visible = false;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            var res = txtResultado.Text;
            txtResultado.Text = res + 1;
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 2;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 3;
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 4;
        }

        private void lbl5_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 5;
        }

        private void lbl6_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 6;
        }

        private void lbl7_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 7;
        }

        private void lbl8_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 8;
        }

        private void lbl9_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 9;
        }

        private void lbl0_Click(object sender, EventArgs e)
        {
            var res = txtResultado.Text;
            txtResultado.Text = res + 0;
        }

        private void lblSomar_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "+";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void lblCalcular_Click(object sender, EventArgs e)
        {
            if (lblSinal.Text == "+")
            {
                v2 = Convert.ToInt32(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 + v2;
                txtResultado.Text = soma.ToString();
            }
            else if (lblSinal.Text == "-")
            {
                v2 = Convert.ToInt32(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 - v2;
                txtResultado.Text = soma.ToString();
            }
            else if (lblSinal.Text == "x")
            {
                v2 = Convert.ToInt32(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 * v2;
                txtResultado.Text = soma.ToString();
            }
            else if (lblSinal.Text == "/")
            {
                v2 = Convert.ToInt32(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 / v2;
                txtResultado.Text = soma.ToString();
            }
        }

        private void lblDiminuir_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "-";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "x";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void lblDividir_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "/";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }
    }
}
