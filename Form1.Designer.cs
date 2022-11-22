namespace Aula13Poo
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
            this.lblTitular = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAbrir = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.BackColor = System.Drawing.Color.Transparent;
            this.lblTitular.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitular.Location = new System.Drawing.Point(26, 75);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(96, 25);
            this.lblTitular.TabIndex = 0;
            this.lblTitular.Text = "Titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.BackColor = System.Drawing.Color.Transparent;
            this.lblAgencia.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.ForeColor = System.Drawing.Color.White;
            this.lblAgencia.Location = new System.Drawing.Point(26, 123);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(104, 25);
            this.lblAgencia.TabIndex = 2;
            this.lblAgencia.Text = "Agência:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 261);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // lblAbrir
            // 
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.BackColor = System.Drawing.Color.Black;
            this.lblAbrir.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrir.ForeColor = System.Drawing.Color.White;
            this.lblAbrir.Location = new System.Drawing.Point(76, 29);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(224, 32);
            this.lblAbrir.TabIndex = 4;
            this.lblAbrir.Text = "ABRIR CONTA";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.BackColor = System.Drawing.Color.Transparent;
            this.lblConta.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.ForeColor = System.Drawing.Color.White;
            this.lblConta.Location = new System.Drawing.Point(26, 172);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(115, 25);
            this.lblConta.TabIndex = 5;
            this.lblConta.Text = "Nº Conta:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(26, 221);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(79, 25);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(144, 81);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(201, 20);
            this.txtTitular.TabIndex = 7;
            this.txtTitular.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(144, 128);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(201, 20);
            this.txtAgencia.TabIndex = 8;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(144, 177);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(201, 20);
            this.txtConta.TabIndex = 9;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(144, 227);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(201, 20);
            this.txtSaldo.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExibir);
            this.panel1.Controls.Add(this.btnDepositar);
            this.panel1.Controls.Add(this.btnSacar);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Location = new System.Drawing.Point(392, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 399);
            this.panel1.TabIndex = 11;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValor.Location = new System.Drawing.Point(26, 160);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(78, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(120, 160);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(255, 20);
            this.txtValor.TabIndex = 8;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Black;
            this.btnCriar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(231, 339);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(135, 42);
            this.btnCriar.TabIndex = 12;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Black;
            this.btnSacar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.ForeColor = System.Drawing.Color.White;
            this.btnSacar.Location = new System.Drawing.Point(120, 272);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(160, 46);
            this.btnSacar.TabIndex = 13;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.Black;
            this.btnDepositar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.ForeColor = System.Drawing.Color.White;
            this.btnDepositar.Location = new System.Drawing.Point(120, 211);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(160, 46);
            this.btnDepositar.TabIndex = 14;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Black;
            this.btnExibir.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.Color.White;
            this.btnExibir.Location = new System.Drawing.Point(120, 334);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(160, 46);
            this.btnExibir.TabIndex = 15;
            this.btnExibir.Text = "Exibir Saldo";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Aula13Poo.Properties.Resources.download;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(16, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 116);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Aula13Poo.Properties.Resources.monopoly_sem_fundo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 204);
            this.panel3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(811, 477);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblAbrir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

