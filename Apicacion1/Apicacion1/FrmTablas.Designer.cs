namespace Apicacion1
{
    partial class FrmTablas
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
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.btnMostrarTabla = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.RichTextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnMostrarTablaWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(12, 9);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(118, 20);
            this.txtTabla.TabIndex = 0;
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.Location = new System.Drawing.Point(224, 8);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(136, 23);
            this.btnMostrarTabla.TabIndex = 1;
            this.btnMostrarTabla.Text = "Mostrar Tabla Ciclo For";
            this.btnMostrarTabla.UseVisualStyleBackColor = true;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(12, 38);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(499, 400);
            this.txtResultados.TabIndex = 2;
            this.txtResultados.Text = "";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(136, 9);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(82, 20);
            this.txtLimite.TabIndex = 3;
            // 
            // btnMostrarTablaWhile
            // 
            this.btnMostrarTablaWhile.Location = new System.Drawing.Point(366, 9);
            this.btnMostrarTablaWhile.Name = "btnMostrarTablaWhile";
            this.btnMostrarTablaWhile.Size = new System.Drawing.Size(145, 23);
            this.btnMostrarTablaWhile.TabIndex = 4;
            this.btnMostrarTablaWhile.Text = "Mostrar Tabla Ciclo While";
            this.btnMostrarTablaWhile.UseVisualStyleBackColor = true;
            this.btnMostrarTablaWhile.Click += new System.EventHandler(this.btnMostrarTablaWhile_Click);
            // 
            // FrmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.btnMostrarTablaWhile);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnMostrarTabla);
            this.Controls.Add(this.txtTabla);
            this.Name = "FrmTablas";
            this.Text = "Tablas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Button btnMostrarTabla;
        private System.Windows.Forms.RichTextBox txtResultados;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnMostrarTablaWhile;
    }
}