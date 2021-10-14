using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Instância da classe Calculadora
            Calculadora calc = new Calculadora(Convert.ToDouble(txtN1.Text),
                Convert.ToDouble(txtN2.Text));

           //Chamar o método
            calc.somar();

            //Exibir o resultado
            lblRes.Text = calc.res.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            //Passar os valores das textbox para os atributos do objeto calc
            calc.n1 = Convert.ToDouble(txtN1.Text);
            calc.n2 = Convert.ToDouble(txtN2.Text);

            //Chamar o método
            calc.subtrair();
            //Exibir o resultado
            lblRes.Text = calc.res.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            double a, b;
            a = Convert.ToDouble(txtN1.Text);
            b = Convert.ToDouble(txtN2.Text);

            //Passar os valores das textbox para os atributos do objeto calc
            calc.n1 = a;
            calc.n2 = b;

            //Chamar o método
            calc.multiplicar();
            //Exibir o resultado
            lblRes.Text = calc.res.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(txtN1.Text);
            b = Convert.ToDouble(txtN2.Text);

            Calculadora calc = new Calculadora(a,b);

            //Chamar o método
            calc.dividir();
            //Exibir o resultado
            lblRes.Text = calc.res.ToString();
        }
    }
}
