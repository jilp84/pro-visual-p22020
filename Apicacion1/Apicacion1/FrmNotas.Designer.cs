namespace Apicacion1
{
    partial class FrmNotas
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblN3 = new System.Windows.Forms.Label();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcularProm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(104, 33);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 0;
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(55, 37);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(44, 13);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Notal 1:";
            
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(209, 37);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(42, 13);
            this.lblN2.TabIndex = 3;
            this.lblN2.Text = "Nota 2:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(255, 33);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 2;
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(364, 37);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(42, 13);
            this.lblN3.TabIndex = 5;
            this.lblN3.Text = "Nota 3:";
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(407, 33);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 20);
            this.txtN3.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(41, 82);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(104, 78);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // btnCalcularProm
            // 
            this.btnCalcularProm.Location = new System.Drawing.Point(535, 33);
            this.btnCalcularProm.Name = "btnCalcularProm";
            this.btnCalcularProm.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularProm.TabIndex = 8;
            this.btnCalcularProm.Text = "Premediar";
            this.btnCalcularProm.UseVisualStyleBackColor = true;
            this.btnCalcularProm.Click += new System.EventHandler(this.btnCalcularProm_Click);
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularProm);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.txtN1);
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcularProm;
    }
}