namespace Apicacion1
{
    partial class FrmOperacionesBasicas
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
            this.grTextos = new System.Windows.Forms.GroupBox();
            this.lblN1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.grOperaciones = new System.Windows.Forms.GroupBox();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.grResultado = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grTextos.SuspendLayout();
            this.grOperaciones.SuspendLayout();
            this.grResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grTextos
            // 
            this.grTextos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grTextos.Controls.Add(this.txtN2);
            this.grTextos.Controls.Add(this.lblN2);
            this.grTextos.Controls.Add(this.txtN1);
            this.grTextos.Controls.Add(this.lblN1);
            this.grTextos.Location = new System.Drawing.Point(12, 12);
            this.grTextos.Name = "grTextos";
            this.grTextos.Size = new System.Drawing.Size(363, 74);
            this.grTextos.TabIndex = 0;
            this.grTextos.TabStop = false;
            this.grTextos.Text = "Valores";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(32, 32);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(56, 13);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "Numero 1:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(88, 29);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtN2.Location = new System.Drawing.Point(248, 29);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(99, 20);
            this.txtN2.TabIndex = 3;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(192, 32);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(56, 13);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "Numero 2:";
            // 
            // grOperaciones
            // 
            this.grOperaciones.Controls.Add(this.rbDividir);
            this.grOperaciones.Controls.Add(this.rbMultiplicar);
            this.grOperaciones.Controls.Add(this.rbResta);
            this.grOperaciones.Controls.Add(this.rbSuma);
            this.grOperaciones.Location = new System.Drawing.Point(12, 92);
            this.grOperaciones.Name = "grOperaciones";
            this.grOperaciones.Size = new System.Drawing.Size(363, 69);
            this.grOperaciones.TabIndex = 1;
            this.grOperaciones.TabStop = false;
            this.grOperaciones.Text = "Operaciones";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Location = new System.Drawing.Point(45, 31);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(52, 17);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(106, 31);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(53, 17);
            this.rbResta.TabIndex = 1;
            this.rbResta.TabStop = true;
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Location = new System.Drawing.Point(170, 31);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbMultiplicar.TabIndex = 2;
            this.rbMultiplicar.TabStop = true;
            this.rbMultiplicar.Text = "Multiplicar";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbDividir
            // 
            this.rbDividir.AutoSize = true;
            this.rbDividir.Location = new System.Drawing.Point(248, 31);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(54, 17);
            this.rbDividir.TabIndex = 3;
            this.rbDividir.TabStop = true;
            this.rbDividir.Text = "Dividir";
            this.rbDividir.UseVisualStyleBackColor = true;
            // 
            // grResultado
            // 
            this.grResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grResultado.Controls.Add(this.label1);
            this.grResultado.Controls.Add(this.lblResultado);
            this.grResultado.Controls.Add(this.btnCalcular);
            this.grResultado.Location = new System.Drawing.Point(12, 167);
            this.grResultado.Name = "grResultado";
            this.grResultado.Size = new System.Drawing.Size(363, 65);
            this.grResultado.TabIndex = 2;
            this.grResultado.TabStop = false;
            this.grResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(14, 26);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Maroon;
            this.lblResultado.Location = new System.Drawing.Point(216, 26);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(21, 24);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado:";
            // 
            // FrmOperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 238);
            this.Controls.Add(this.grResultado);
            this.Controls.Add(this.grOperaciones);
            this.Controls.Add(this.grTextos);
            this.Name = "FrmOperacionesBasicas";
            this.Text = "FrmOperacionesBasicas";
            this.grTextos.ResumeLayout(false);
            this.grTextos.PerformLayout();
            this.grOperaciones.ResumeLayout(false);
            this.grOperaciones.PerformLayout();
            this.grResultado.ResumeLayout(false);
            this.grResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTextos;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.GroupBox grOperaciones;
        private System.Windows.Forms.RadioButton rbDividir;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.GroupBox grResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}