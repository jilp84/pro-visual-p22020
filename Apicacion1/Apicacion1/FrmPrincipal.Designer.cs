﻿namespace Apicacion1
{
    partial class FrmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperacionesBasicas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPromedio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArrays = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuOpciones});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSalir.Text = "Salir";
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColores,
            this.mnuOperacionesBasicas,
            this.mnuClientes,
            this.tablasToolStripMenuItem,
            this.mnuPromedio,
            this.mnuArrays,
            this.mnuSwitch,
            this.matrizToolStripMenuItem});
            this.mnuOpciones.Name = "mnuOpciones";
            this.mnuOpciones.Size = new System.Drawing.Size(69, 20);
            this.mnuOpciones.Text = "Opciones";
            // 
            // mnuColores
            // 
            this.mnuColores.Name = "mnuColores";
            this.mnuColores.Size = new System.Drawing.Size(181, 22);
            this.mnuColores.Text = "Colores";
            this.mnuColores.Click += new System.EventHandler(this.mnuColores_Click);
            // 
            // mnuOperacionesBasicas
            // 
            this.mnuOperacionesBasicas.Name = "mnuOperacionesBasicas";
            this.mnuOperacionesBasicas.Size = new System.Drawing.Size(181, 22);
            this.mnuOperacionesBasicas.Text = "Operaciones Basicas";
            this.mnuOperacionesBasicas.Click += new System.EventHandler(this.mnuOperacionesBasicas_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(181, 22);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tablasToolStripMenuItem.Text = "Tablas";
            this.tablasToolStripMenuItem.Click += new System.EventHandler(this.tablasToolStripMenuItem_Click);
            // 
            // mnuPromedio
            // 
            this.mnuPromedio.Name = "mnuPromedio";
            this.mnuPromedio.Size = new System.Drawing.Size(181, 22);
            this.mnuPromedio.Text = "Promedio";
            this.mnuPromedio.Click += new System.EventHandler(this.mnuPromedio_Click);
            // 
            // mnuArrays
            // 
            this.mnuArrays.Name = "mnuArrays";
            this.mnuArrays.Size = new System.Drawing.Size(181, 22);
            this.mnuArrays.Text = "Arrays";
            this.mnuArrays.Click += new System.EventHandler(this.mnuArrays_Click);
            // 
            // mnuSwitch
            // 
            this.mnuSwitch.Name = "mnuSwitch";
            this.mnuSwitch.Size = new System.Drawing.Size(181, 22);
            this.mnuSwitch.Text = "Switch";
            this.mnuSwitch.Click += new System.EventHandler(this.mnuSwitch_Click);
            // 
            // matrizToolStripMenuItem
            // 
            this.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem";
            this.matrizToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.matrizToolStripMenuItem.Text = "Matriz";
            this.matrizToolStripMenuItem.Click += new System.EventHandler(this.matrizToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuColores;
        private System.Windows.Forms.ToolStripMenuItem mnuOperacionesBasicas;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPromedio;
        private System.Windows.Forms.ToolStripMenuItem mnuArrays;
        private System.Windows.Forms.ToolStripMenuItem mnuSwitch;
        private System.Windows.Forms.ToolStripMenuItem matrizToolStripMenuItem;
    }
}