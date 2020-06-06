namespace Apicacion1
{
    partial class FrmSwitch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnDia = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDia);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Día de la semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de día:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(98, 22);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 1;
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(201, 21);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(75, 23);
            this.btnDia.TabIndex = 2;
            this.btnDia.Text = "Mostrar día";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // lblDia
            // 
            this.lblDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(12, 72);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(285, 80);
            this.lblDia.TabIndex = 1;
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 165);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSwitch";
            this.Text = "FrmSwitch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDia;
    }
}