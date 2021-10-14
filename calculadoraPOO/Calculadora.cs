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

        //Métodos
        public void somar()
        {
            this.res = this.n1 + this.n2;
            
        }

        public void subtrair()
        {
            this.res = this.n1 - this.n2;
           
        }

        public void multiplicar()
        {
            this.res = this.n1 * this.n2;
            
        }

        public void dividir()
        {
            if (this.n2 == 0)
            {
                MessageBox.Show("Não é possível dividir por 0!");
                this.res = 0;
            }
            else
            {
                this.res = this.n1 / this.n2;
   
            }
        }


    }
}
