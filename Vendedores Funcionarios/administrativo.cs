using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedores_Funcionarios
{
    class administrativo : Funcionario
    {
        protected double horas;

        public double getHoras()
        {
            return horas;
        }
        public void InformaHoras(double valor)
        {
            horas += valor;
        }
        public double CalculaSalario()
        {
            return salario + horas * (salario / 100);
        }

    }
}
