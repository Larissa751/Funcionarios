using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedores_Funcionarios
{
    public class Funcionario
    {
        protected String nome;
        protected String rg;
        protected double salario;

        public String getNome()
        {
            return nome;
        }
        public String getRG()
        {
            return rg;
        }
        public Double getSalario()
        {
            return salario;
        }
        public void setNome(string n)
        {
            nome = n;
        }
        public void setRG(string r)
        {
            rg = r;
        }
        public void setSalario(double s)
        {
            salario = s;
        }
    }
}