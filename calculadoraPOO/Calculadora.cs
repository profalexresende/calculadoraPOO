using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraPOO
{
    class Calculadora
    {
        //Declaração de atributos
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double res { get; set; }

        //Método construtor
        public Calculadora()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.res = 0;
        }

        public Calculadora(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.res = 0;
        }

        //Métodos
        public void somar()
        {
            this.res = this.n1 + this.n2;
        }

        public void subtrair(double a, double b)
        {
            this.res = a - b;
        }

        public double multiplicar()
        {
            return this.n1 * this.n2;
        }

        public double dividir(double a, double b)
        {
            double resposta = 0;
            if (b == 0)
            {
                MessageBox.Show("Não é possível dividir por 0!");
            }
            else
            {
                resposta = a / b;
            }
            return resposta;
        }
    }
}
