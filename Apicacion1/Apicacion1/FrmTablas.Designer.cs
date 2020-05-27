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
            this.SuspendLayout();
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(12, 8);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(118, 20);
            this.txtTabla.TabIndex = 0;
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.Location = new System.Drawing.Point(136, 7);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(92, 23);
            this.btnMostrarTabla.TabIndex = 1;
            this.btnMostrarTabla.Text = "Mostrar Tabla";
            this.btnMostrarTabla.UseVisualStyleBackColor = true;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(12, 38);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(216, 400);
            this.txtResultados.TabIndex = 2;
            this.txtResultados.Text = "";
            // 
            // FrmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 450);
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
    }
}