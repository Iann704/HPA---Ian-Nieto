namespace Lab_1
{
    partial class Form1
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFechafinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(80, 77);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(28, 16);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia";
            this.lblDia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(80, 160);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(33, 16);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mes";
            this.lblMes.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(80, 240);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(31, 16);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(197, 70);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 22);
            this.txtDia.TabIndex = 3;
            this.txtDia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(197, 154);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 22);
            this.txtMes.TabIndex = 4;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(197, 233);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 22);
            this.txtAño.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(197, 326);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(336, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblFechafinal
            // 
            this.lblFechafinal.AutoSize = true;
            this.lblFechafinal.Location = new System.Drawing.Point(406, 87);
            this.lblFechafinal.Name = "lblFechafinal";
            this.lblFechafinal.Size = new System.Drawing.Size(84, 16);
            this.lblFechafinal.TabIndex = 8;
            this.lblFechafinal.Text = "La Fecha es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechafinal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Name = "Form1";
            this.Text = "Practica de Controles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFechafinal;
    }
}

