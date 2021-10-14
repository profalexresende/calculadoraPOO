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

        //Instância da classe Calculadora
        Calculadora calc = new Calculadora();

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Passar os valores das textbox para os atributos do objeto calc
            calc.n1 = Convert.ToDouble(txtN1.Text);
            calc.n2 = Convert.ToDouble(txtN2.Text);

            //Chamar o método
            calc.somar();

            //Exibir o resultado
            lblRes.Text = calc.res.ToString();

            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
           
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
           
            //Passar os valores das textbox para os atributos do objeto calc
            calc.n1 = Convert.ToDouble(txtN1.Text);
            calc.n2 = Convert.ToDouble(txtN2.Text);

            //Chamar o método
            calc.multiplicar();
            //Exibir o resultado
            lblRes.Text = calc.res.ToString();


        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
           
            //Passar os valores das textbox para os atributos do objeto calc
            calc.n1 = Convert.ToDouble(txtN1.Text);
            calc.n2 = Convert.ToDouble(txtN2.Text);

            //Chamar o método
            calc.dividir();
            //Exibir o resultado
            lblRes.Text = calc.res.ToString();


        }
    }
}
