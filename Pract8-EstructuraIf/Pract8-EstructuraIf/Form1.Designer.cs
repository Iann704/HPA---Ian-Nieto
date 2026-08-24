namespace Pract8_EstructuraIf
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
            this.lblTItulo = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDivision = new System.Windows.Forms.RadioButton();
            this.rbtMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbtResta = new System.Windows.Forms.RadioButton();
            this.rbtSuma = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTItulo
            // 
            this.lblTItulo.AutoSize = true;
            this.lblTItulo.Location = new System.Drawing.Point(12, 24);
            this.lblTItulo.Name = "lblTItulo";
            this.lblTItulo.Size = new System.Drawing.Size(269, 16);
            this.lblTItulo.TabIndex = 0;
            this.lblTItulo.Text = "Ingresa los valores y selecciona una opción";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(380, 79);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(196, 79);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 2;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(15, 79);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 3;
            this.txtNum1.Click += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(149, 82);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(14, 16);
            this.lblSigno.TabIndex = 4;
            this.lblSigno.Text = "+";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(333, 79);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(14, 16);
            this.lblIgual.TabIndex = 5;
            this.lblIgual.Text = "=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDivision);
            this.groupBox1.Controls.Add(this.rbtMultiplicacion);
            this.groupBox1.Controls.Add(this.rbtResta);
            this.groupBox1.Controls.Add(this.rbtSuma);
            this.groupBox1.Location = new System.Drawing.Point(43, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operación";
            this.groupBox1.Enter += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbtDivision
            // 
            this.rbtDivision.AutoSize = true;
            this.rbtDivision.Location = new System.Drawing.Point(7, 139);
            this.rbtDivision.Name = "rbtDivision";
            this.rbtDivision.Size = new System.Drawing.Size(76, 20);
            this.rbtDivision.TabIndex = 3;
            this.rbtDivision.TabStop = true;
            this.rbtDivision.Text = "División";
            this.rbtDivision.UseVisualStyleBackColor = true;
            // 
            // rbtMultiplicacion
            // 
            this.rbtMultiplicacion.AutoSize = true;
            this.rbtMultiplicacion.Location = new System.Drawing.Point(7, 99);
            this.rbtMultiplicacion.Name = "rbtMultiplicacion";
            this.rbtMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rbtMultiplicacion.TabIndex = 2;
            this.rbtMultiplicacion.TabStop = true;
            this.rbtMultiplicacion.Text = "Multiplicación";
            this.rbtMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbtResta
            // 
            this.rbtResta.AutoSize = true;
            this.rbtResta.Location = new System.Drawing.Point(7, 59);
            this.rbtResta.Name = "rbtResta";
            this.rbtResta.Size = new System.Drawing.Size(64, 20);
            this.rbtResta.TabIndex = 1;
            this.rbtResta.TabStop = true;
            this.rbtResta.Text = "Resta";
            this.rbtResta.UseVisualStyleBackColor = true;
            // 
            // rbtSuma
            // 
            this.rbtSuma.AutoSize = true;
            this.rbtSuma.Location = new System.Drawing.Point(7, 22);
            this.rbtSuma.Name = "rbtSuma";
            this.rbtSuma.Size = new System.Drawing.Size(63, 20);
            this.rbtSuma.TabIndex = 0;
            this.rbtSuma.TabStop = true;
            this.rbtSuma.Text = "Suma";
            this.rbtSuma.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(336, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(336, 238);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 373);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblTItulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTItulo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDivision;
        private System.Windows.Forms.RadioButton rbtMultiplicacion;
        private System.Windows.Forms.RadioButton rbtResta;
        private System.Windows.Forms.RadioButton rbtSuma;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}

