namespace Vendedores_Funcionarios
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRealizarVenda = new System.Windows.Forms.Button();
            this.btnRegistrarhoras = new System.Windows.Forms.Button();
            this.btnCalcularsalario = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.txbSalário = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.rbAdministrativo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnRealizarVenda
            // 
            this.btnRealizarVenda.Enabled = false;
            this.btnRealizarVenda.Location = new System.Drawing.Point(101, 255);
            this.btnRealizarVenda.Name = "btnRealizarVenda";
            this.btnRealizarVenda.Size = new System.Drawing.Size(103, 23);
            this.btnRealizarVenda.TabIndex = 4;
            this.btnRealizarVenda.Text = "Realizar venda";
            this.btnRealizarVenda.UseVisualStyleBackColor = true;
            this.btnRealizarVenda.Click += new System.EventHandler(this.btnRealizarVenda_Click);
            // 
            // btnRegistrarhoras
            // 
            this.btnRegistrarhoras.Enabled = false;
            this.btnRegistrarhoras.Location = new System.Drawing.Point(220, 255);
            this.btnRegistrarhoras.Name = "btnRegistrarhoras";
            this.btnRegistrarhoras.Size = new System.Drawing.Size(97, 23);
            this.btnRegistrarhoras.TabIndex = 5;
            this.btnRegistrarhoras.Text = "Registrar horas";
            this.btnRegistrarhoras.UseVisualStyleBackColor = true;
            this.btnRegistrarhoras.Click += new System.EventHandler(this.btnRegistrarhoras_Click);
            // 
            // btnCalcularsalario
            // 
            this.btnCalcularsalario.Enabled = false;
            this.btnCalcularsalario.Location = new System.Drawing.Point(338, 255);
            this.btnCalcularsalario.Name = "btnCalcularsalario";
            this.btnCalcularsalario.Size = new System.Drawing.Size(95, 23);
            this.btnCalcularsalario.TabIndex = 6;
            this.btnCalcularsalario.Text = "Calcular Salário";
            this.btnCalcularsalario.UseVisualStyleBackColor = true;
            this.btnCalcularsalario.Click += new System.EventHandler(this.btnCalcularsalario_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(456, 255);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(551, 255);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(560, 104);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 9;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(129, 45);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 14;
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(129, 83);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(100, 20);
            this.txbRG.TabIndex = 15;
            // 
            // txbSalário
            // 
            this.txbSalário.Location = new System.Drawing.Point(129, 124);
            this.txbSalário.Name = "txbSalário";
            this.txbSalário.Size = new System.Drawing.Size(100, 20);
            this.txbSalário.TabIndex = 16;
            // 
            // txbValor
            // 
            this.txbValor.Enabled = false;
            this.txbValor.Location = new System.Drawing.Point(129, 177);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 17;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(372, 83);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbVendedor.TabIndex = 18;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            // 
            // rbAdministrativo
            // 
            this.rbAdministrativo.AutoSize = true;
            this.rbAdministrativo.Location = new System.Drawing.Point(372, 152);
            this.rbAdministrativo.Name = "rbAdministrativo";
            this.rbAdministrativo.Size = new System.Drawing.Size(90, 17);
            this.rbAdministrativo.TabIndex = 19;
            this.rbAdministrativo.TabStop = true;
            this.rbAdministrativo.Text = "Administrativo";
            this.rbAdministrativo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbAdministrativo);
            this.Controls.Add(this.rbVendedor);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.txbSalário);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcularsalario);
            this.Controls.Add(this.btnRegistrarhoras);
            this.Controls.Add(this.btnRealizarVenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRealizarVenda;
        private System.Windows.Forms.Button btnRegistrarhoras;
        private System.Windows.Forms.Button btnCalcularsalario;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.TextBox txbSalário;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.RadioButton rbAdministrativo;
    }
}

