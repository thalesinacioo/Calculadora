using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        
        string operacao = "";




        public Form1()
        {
            InitializeComponent();
        }

        private void btzero_Click(object sender, EventArgs e)
        {
           
        txtresultado.Text += "0";
        }

        private void btone_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void bttwo_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void btthree_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
        }

        private void btdot_Click(object sender, EventArgs e)
        {
            txtresultado.Text += ".";
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        private void btequal_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "soma")
            {
                txtresultado.Text = Convert.ToString(valor1 + valor2);
                lbloperacao.Text = valor1 + "+" + valor2;
            }
            if(operacao == "menus")
            {
                txtresultado.Text = Convert.ToString(valor1 - valor2);
                lbloperacao.Text = valor1 + "-" + valor2;    
            }
            if (operacao == "multiplica")
            {
                txtresultado.Text = Convert.ToString(valor1 * valor2);
                lbloperacao.Text = valor1 + "x" + valor2;
            }
            if (operacao == "dividi")
            {
                txtresultado.Text = Convert.ToString(valor1 / valor2);
                lbloperacao.Text = valor1 + "/" + valor2;
            }
        }

        private void btplus_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "soma";

                lbloperacao.Text = valor1 + "+";
            }
        }

        private void btminus_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "menus";

                lbloperacao.Text = valor1 + "-";

            }
        }

        private void btmultiply_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "multiplica";

                lbloperacao.Text = valor1 + "x";
            }
        }

        private void btdivider_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "dividi";

                lbloperacao.Text = valor1 + "/";
            }
        }

        private void btCe_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            /* txtresultado.Text = "";  //limpar
             valor1 = 0;                //limpar variavel 1
             valor2 = 0;
             lbloperacao.Text = "";     //limpar o label
             */

            if (txtresultado.Text.Length > 0)
            {
                txtresultado.Text = txtresultado.Text.Remove(txtresultado.Text.Length - 1, 1);
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
