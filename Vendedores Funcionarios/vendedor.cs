using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedores_Funcionarios
{
    class vendedor : Funcionario
    {
        private double vendas;

        protected double getvendas()

        {
            return vendas;
        }
        public void setvendas(double v)
        {
            vendas = v;
        }
        public void registrarvendas(double valor)
        {
            vendas += valor;
        }
        public double calcularSalario()
        {
            return salario + vendas * 0.5;
        }
    }
}