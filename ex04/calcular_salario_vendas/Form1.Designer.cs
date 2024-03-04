
namespace ex04
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lablNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSalarioFixo = new System.Windows.Forms.TextBox();
            this.textTotalVendas = new System.Windows.Forms.TextBox();
            this.bntSalario = new System.Windows.Forms.Button();
            this.lblSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lablNome
            // 
            this.lablNome.AutoSize = true;
            this.lablNome.Location = new System.Drawing.Point(212, 79);
            this.lablNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lablNome.Name = "lablNome";
            this.lablNome.Size = new System.Drawing.Size(53, 16);
            this.lablNome.TabIndex = 0;
            this.lablNome.Text = "Nome:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(212, 118);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(95, 16);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salario Fixo:";
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Location = new System.Drawing.Point(212, 166);
            this.lblVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(125, 16);
            this.lblVendas.TabIndex = 2;
            this.lblVendas.Text = "Total de vendas:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(278, 75);
            this.textNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(214, 22);
            this.textNome.TabIndex = 3;
            // 
            // textSalarioFixo
            // 
            this.textSalarioFixo.Location = new System.Drawing.Point(316, 114);
            this.textSalarioFixo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSalarioFixo.Name = "textSalarioFixo";
            this.textSalarioFixo.Size = new System.Drawing.Size(190, 22);
            this.textSalarioFixo.TabIndex = 4;
            // 
            // textTotalVendas
            // 
            this.textTotalVendas.Location = new System.Drawing.Point(345, 163);
            this.textTotalVendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTotalVendas.Name = "textTotalVendas";
            this.textTotalVendas.Size = new System.Drawing.Size(178, 22);
            this.textTotalVendas.TabIndex = 5;
            // 
            // bntSalario
            // 
            this.bntSalario.BackColor = System.Drawing.Color.Coral;
            this.bntSalario.Location = new System.Drawing.Point(306, 212);
            this.bntSalario.Name = "bntSalario";
            this.bntSalario.Size = new System.Drawing.Size(115, 59);
            this.bntSalario.TabIndex = 6;
            this.bntSalario.Text = "Calcular Salario Mensal";
            this.bntSalario.UseVisualStyleBackColor = false;
            this.bntSalario.Click += new System.EventHandler(this.bntSalario_Click);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(169, 289);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 16);
            this.lblSaida.TabIndex = 7;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 314);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.bntSalario);
            this.Controls.Add(this.textTotalVendas);
            this.Controls.Add(this.textSalarioFixo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.lblVendas);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lablNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTelaPrincipal";
            this.Text = "Calculador de percentual de vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSalarioFixo;
        private System.Windows.Forms.TextBox textTotalVendas;
        private System.Windows.Forms.Button bntSalario;
        private System.Windows.Forms.Label lblSaida;
    }
}

