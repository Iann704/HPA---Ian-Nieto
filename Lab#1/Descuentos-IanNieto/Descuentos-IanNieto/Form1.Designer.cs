namespace Descuentos_IanNieto
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
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblDescporc = new System.Windows.Forms.Label();
            this.lblVentafinal = new System.Windows.Forms.Label();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtDescporc = new System.Windows.Forms.TextBox();
            this.txtVentafin = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(56, 96);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(87, 16);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor Venta $";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(56, 185);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(82, 16);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento $";
            // 
            // lblDescporc
            // 
            this.lblDescporc.AutoSize = true;
            this.lblDescporc.Location = new System.Drawing.Point(56, 265);
            this.lblDescporc.Name = "lblDescporc";
            this.lblDescporc.Size = new System.Drawing.Size(87, 16);
            this.lblDescporc.TabIndex = 2;
            this.lblDescporc.Text = "Descuento %";
            // 
            // lblVentafinal
            // 
            this.lblVentafinal.AutoSize = true;
            this.lblVentafinal.Location = new System.Drawing.Point(56, 362);
            this.lblVentafinal.Name = "lblVentafinal";
            this.lblVentafinal.Size = new System.Drawing.Size(84, 16);
            this.lblVentafinal.TabIndex = 3;
            this.lblVentafinal.Text = "Venta Final $";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(190, 96);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(100, 22);
            this.txtValorVenta.TabIndex = 4;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(190, 185);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento.TabIndex = 5;
            // 
            // txtDescporc
            // 
            this.txtDescporc.Location = new System.Drawing.Point(190, 265);
            this.txtDescporc.Name = "txtDescporc";
            this.txtDescporc.ReadOnly = true;
            this.txtDescporc.Size = new System.Drawing.Size(100, 22);
            this.txtDescporc.TabIndex = 6;
            // 
            // txtVentafin
            // 
            this.txtVentafin.Location = new System.Drawing.Point(190, 362);
            this.txtVentafin.Name = "txtVentafin";
            this.txtVentafin.ReadOnly = true;
            this.txtVentafin.Size = new System.Drawing.Size(100, 22);
            this.txtVentafin.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(514, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(514, 164);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(514, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVentafin);
            this.Controls.Add(this.txtDescporc);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.lblVentafinal);
            this.Controls.Add(this.lblDescporc);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Descuentos-Programado por: Ian Nieto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblDescporc;
        private System.Windows.Forms.Label lblVentafinal;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtDescporc;
        private System.Windows.Forms.TextBox txtVentafin;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

