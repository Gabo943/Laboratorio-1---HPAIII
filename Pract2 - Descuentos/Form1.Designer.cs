namespace Pract2___Descuentos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescDin = new System.Windows.Forms.Label();
            this.lblDescPorcen = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtDescDin = new System.Windows.Forms.TextBox();
            this.txtDescPorcen = new System.Windows.Forms.TextBox();
            this.txtVentaFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(95, 77);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(77, 16);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor Venta";
            // 
            // lblDescDin
            // 
            this.lblDescDin.AutoSize = true;
            this.lblDescDin.Location = new System.Drawing.Point(95, 144);
            this.lblDescDin.Name = "lblDescDin";
            this.lblDescDin.Size = new System.Drawing.Size(82, 16);
            this.lblDescDin.TabIndex = 1;
            this.lblDescDin.Text = "Descuento $";
            this.lblDescDin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDescPorcen
            // 
            this.lblDescPorcen.AutoSize = true;
            this.lblDescPorcen.Location = new System.Drawing.Point(95, 212);
            this.lblDescPorcen.Name = "lblDescPorcen";
            this.lblDescPorcen.Size = new System.Drawing.Size(87, 16);
            this.lblDescPorcen.TabIndex = 2;
            this.lblDescPorcen.Text = "Descuento %";
            this.lblDescPorcen.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(95, 286);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(74, 16);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(534, 74);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(534, 137);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(534, 279);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(222, 71);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(100, 22);
            this.txtValorVenta.TabIndex = 7;
            // 
            // txtDescDin
            // 
            this.txtDescDin.Location = new System.Drawing.Point(222, 144);
            this.txtDescDin.Name = "txtDescDin";
            this.txtDescDin.Size = new System.Drawing.Size(100, 22);
            this.txtDescDin.TabIndex = 8;
            // 
            // txtDescPorcen
            // 
            this.txtDescPorcen.Location = new System.Drawing.Point(222, 212);
            this.txtDescPorcen.Name = "txtDescPorcen";
            this.txtDescPorcen.Size = new System.Drawing.Size(100, 22);
            this.txtDescPorcen.TabIndex = 9;
            // 
            // txtVentaFinal
            // 
            this.txtVentaFinal.Location = new System.Drawing.Point(222, 286);
            this.txtVentaFinal.Name = "txtVentaFinal";
            this.txtVentaFinal.Size = new System.Drawing.Size(100, 22);
            this.txtVentaFinal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVentaFinal);
            this.Controls.Add(this.txtDescPorcen);
            this.Controls.Add(this.txtDescDin);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblDescPorcen);
            this.Controls.Add(this.lblDescDin);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Descuentos – Programado por: Gabriel Jiménez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescDin;
        private System.Windows.Forms.Label lblDescPorcen;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.TextBox txtDescDin;
        private System.Windows.Forms.TextBox txtDescPorcen;
        private System.Windows.Forms.TextBox txtVentaFinal;
    }
}

