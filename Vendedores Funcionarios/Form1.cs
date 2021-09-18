using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendedores_Funcionarios
{
    public partial class Form1 : Form

    {
        vendedor vendedor;
        administrativo administrativo;

        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close ();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (rbAdministrativo.Checked)
            {
                administrativo = new administrativo();
                administrativo.setNome(txbNome.Text);
                administrativo.setRG(txbRG.Text);
                administrativo.setSalario(Double.Parse(txbSalário.Text));
                btnRegistrarhoras.Enabled = true;

            }



            else if (rbVendedor.Checked)
            {
                vendedor = new vendedor();
                vendedor.setNome(txbNome.Text);
                vendedor.setRG(txbRG.Text);
                vendedor.setSalario(Double.Parse(txbSalário.Text));
                btnRealizarVenda.Enabled = true;

            }
               
            
            txbValor.Enabled = true;
            btnLimpar.Enabled = true;
            btnCalcularsalario.Enabled = true;

            btnCriar.Enabled = false;
            txbNome.Enabled = false;
            txbRG.Enabled = false;
            txbSalário.Enabled = false;
            rbAdministrativo.Enabled = false;
            rbVendedor.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbRG.Clear();
            txbSalário.Clear();

            txbValor.Enabled = false;
            btnRegistrarhoras.Enabled = false;
            btnRealizarVenda.Enabled = false;
            btnLimpar.Enabled = false;
            btnCalcularsalario.Enabled = false;

            btnCriar.Enabled = true;
            txbNome.Enabled = true;
            txbRG.Enabled = true;
            txbSalário.Enabled = true;
            rbAdministrativo.Enabled = true;
            rbVendedor.Enabled = true;



        }

        private void btnRealizarVenda_Click(object sender, EventArgs e)
        {
            vendedor.registrarvendas(Double.Parse(txbValor.Text));
            txbValor.Clear();
        }

        private void btnRegistrarhoras_Click(object sender, EventArgs e)
        {
            administrativo.InformaHoras(Double.Parse(txbValor.Text));
            txbValor.Clear();
        }

        private void btnCalcularsalario_Click(object sender, EventArgs e)
        {
            if(rbAdministrativo.Checked)
            {
                MessageBox.Show("Oi " + administrativo.getNome() + ", seu salario é: " + administrativo.CalculaSalario());
            }
            else if(rbVendedor.Checked)
            {
                MessageBox.Show("Oi " + vendedor.getNome() + ", seu salario é: " + vendedor.calcularSalario());
            }

        }
    }
}


