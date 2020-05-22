namespace Apicacion1
{
    partial class FrmColores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.RbAmarillo = new System.Windows.Forms.RadioButton();
            this.btnSetColorRB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSetColorRB);
            this.groupBox1.Controls.Add(this.RbAmarillo);
            this.groupBox1.Controls.Add(this.rbRojo);
            this.groupBox1.Controls.Add(this.rbAzul);
            this.groupBox1.Controls.Add(this.btnSetColor);
            this.groupBox1.Controls.Add(this.cmbColores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pnlColor
            // 
            this.pnlColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColor.BackColor = System.Drawing.Color.White;
            this.pnlColor.Location = new System.Drawing.Point(13, 150);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(410, 177);
            this.pnlColor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un color:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Items.AddRange(new object[] {
            "Seleccione un color",
            "Azul",
            "Rojo",
            "Amarillo"});
            this.cmbColores.Location = new System.Drawing.Point(123, 19);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(121, 21);
            this.cmbColores.TabIndex = 1;
            this.cmbColores.Text = "Seleccione un color";
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(253, 18);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(99, 23);
            this.btnSetColor.TabIndex = 2;
            this.btnSetColor.Text = "Cambiar Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.Location = new System.Drawing.Point(21, 81);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(45, 17);
            this.rbAzul.TabIndex = 3;
            this.rbAzul.TabStop = true;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(75, 81);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(47, 17);
            this.rbRojo.TabIndex = 4;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // RbAmarillo
            // 
            this.RbAmarillo.AutoSize = true;
            this.RbAmarillo.Location = new System.Drawing.Point(123, 81);
            this.RbAmarillo.Name = "RbAmarillo";
            this.RbAmarillo.Size = new System.Drawing.Size(61, 17);
            this.RbAmarillo.TabIndex = 5;
            this.RbAmarillo.TabStop = true;
            this.RbAmarillo.Text = "Amarillo";
            this.RbAmarillo.UseVisualStyleBackColor = true;
            // 
            // btnSetColorRB
            // 
            this.btnSetColorRB.Location = new System.Drawing.Point(253, 75);
            this.btnSetColorRB.Name = "btnSetColorRB";
            this.btnSetColorRB.Size = new System.Drawing.Size(99, 23);
            this.btnSetColorRB.TabIndex = 6;
            this.btnSetColorRB.Text = "Cambiar Color";
            this.btnSetColorRB.UseVisualStyleBackColor = true;
            this.btnSetColorRB.Click += new System.EventHandler(this.btnSetColorRB_Click);
            // 
            // FrmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 339);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmColores";
            this.Text = "Colores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetColorRB;
        private System.Windows.Forms.RadioButton RbAmarillo;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbAzul;
    }
}