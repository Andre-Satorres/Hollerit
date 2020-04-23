namespace FolhaPagamento
{
    partial class frmHollerit
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfos = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtDep = new System.Windows.Forms.NumericUpDown();
            this.txtSal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 135);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 26);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salário Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde Dependentes";
            // 
            // txtInfos
            // 
            this.txtInfos.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfos.Location = new System.Drawing.Point(12, 167);
            this.txtInfos.Multiline = true;
            this.txtInfos.Name = "txtInfos";
            this.txtInfos.ReadOnly = true;
            this.txtInfos.Size = new System.Drawing.Size(288, 134);
            this.txtInfos.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(159, 135);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 26);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Tela";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(159, 14);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(141, 20);
            this.txtCPF.TabIndex = 9;
            this.txtCPF.ValidatingType = typeof(int);
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(159, 52);
            this.txtDep.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(141, 20);
            this.txtDep.TabIndex = 10;
            // 
            // txtSal
            // 
            this.txtSal.DecimalPlaces = 2;
            this.txtSal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtSal.Location = new System.Drawing.Point(159, 97);
            this.txtSal.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(141, 20);
            this.txtSal.TabIndex = 11;
            // 
            // frmHollerit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 304);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtInfos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmHollerit";
            this.Text = "Hollerit";
            ((System.ComponentModel.ISupportInitialize)(this.txtDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.NumericUpDown txtDep;
        private System.Windows.Forms.NumericUpDown txtSal;
    }
}

