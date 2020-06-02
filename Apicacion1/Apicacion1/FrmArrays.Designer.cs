namespace Apicacion1
{
    partial class FrmArrays
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
            this.txtTamanioArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearArray = new System.Windows.Forms.Button();
            this.btnAgregarValor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgregarValor = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.RichTextBox();
            this.btnMostrarArray = new System.Windows.Forms.Button();
            this.btnMostrarArrayWhile = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTamanioArray
            // 
            this.txtTamanioArray.Location = new System.Drawing.Point(55, 18);
            this.txtTamanioArray.Name = "txtTamanioArray";
            this.txtTamanioArray.Size = new System.Drawing.Size(93, 20);
            this.txtTamanioArray.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Array";
            // 
            // btnCrearArray
            // 
            this.btnCrearArray.Location = new System.Drawing.Point(154, 17);
            this.btnCrearArray.Name = "btnCrearArray";
            this.btnCrearArray.Size = new System.Drawing.Size(83, 23);
            this.btnCrearArray.TabIndex = 2;
            this.btnCrearArray.Text = "Crear Array";
            this.btnCrearArray.UseVisualStyleBackColor = true;
            this.btnCrearArray.Click += new System.EventHandler(this.btnCrearArray_Click);
            // 
            // btnAgregarValor
            // 
            this.btnAgregarValor.Location = new System.Drawing.Point(444, 17);
            this.btnAgregarValor.Name = "btnAgregarValor";
            this.btnAgregarValor.Size = new System.Drawing.Size(95, 23);
            this.btnAgregarValor.TabIndex = 5;
            this.btnAgregarValor.Text = "Agregar Valor";
            this.btnAgregarValor.UseVisualStyleBackColor = true;
            this.btnAgregarValor.Click += new System.EventHandler(this.btnAgregarValor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar un valor";
            // 
            // txtAgregarValor
            // 
            this.txtAgregarValor.Location = new System.Drawing.Point(336, 18);
            this.txtAgregarValor.Name = "txtAgregarValor";
            this.txtAgregarValor.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarValor.TabIndex = 3;
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(21, 72);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(517, 366);
            this.txtSalida.TabIndex = 6;
            this.txtSalida.Text = "";
            // 
            // btnMostrarArray
            // 
            this.btnMostrarArray.Location = new System.Drawing.Point(443, 46);
            this.btnMostrarArray.Name = "btnMostrarArray";
            this.btnMostrarArray.Size = new System.Drawing.Size(95, 23);
            this.btnMostrarArray.TabIndex = 7;
            this.btnMostrarArray.Text = "Mostrar Array";
            this.btnMostrarArray.UseVisualStyleBackColor = true;
            this.btnMostrarArray.Click += new System.EventHandler(this.btnMostrarArray_Click);
            // 
            // btnMostrarArrayWhile
            // 
            this.btnMostrarArrayWhile.Location = new System.Drawing.Point(309, 46);
            this.btnMostrarArrayWhile.Name = "btnMostrarArrayWhile";
            this.btnMostrarArrayWhile.Size = new System.Drawing.Size(127, 23);
            this.btnMostrarArrayWhile.TabIndex = 8;
            this.btnMostrarArrayWhile.Text = "Mostrar Array While";
            this.btnMostrarArrayWhile.UseVisualStyleBackColor = true;
            this.btnMostrarArrayWhile.Click += new System.EventHandler(this.btnMostrarArrayWhile_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(176, 46);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMostrarArrayWhile);
            this.Controls.Add(this.btnMostrarArray);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.btnAgregarValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAgregarValor);
            this.Controls.Add(this.btnCrearArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamanioArray);
            this.Name = "FrmArrays";
            this.Text = "FrmArrays";
            this.Load += new System.EventHandler(this.FrmArrays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTamanioArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearArray;
        private System.Windows.Forms.Button btnAgregarValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgregarValor;
        private System.Windows.Forms.RichTextBox txtSalida;
        private System.Windows.Forms.Button btnMostrarArray;
        private System.Windows.Forms.Button btnMostrarArrayWhile;
        private System.Windows.Forms.Button btnLimpiar;
    }
}