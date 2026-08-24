namespace Pract3_EstructuraIf
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
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSumar = new System.Windows.Forms.RadioButton();
            this.rbRestar = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(31, 49);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 22);
            this.txtValorA.TabIndex = 0;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(222, 49);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 22);
            this.txtValorB.TabIndex = 1;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(422, 49);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(100, 22);
            this.txtRespuesta.TabIndex = 2;
            this.txtRespuesta.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSumar);
            this.groupBox1.Controls.Add(this.rbRestar);
            this.groupBox1.Controls.Add(this.rbMultiplicar);
            this.groupBox1.Controls.Add(this.rbDividir);
            this.groupBox1.Location = new System.Drawing.Point(41, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbSumar
            // 
            this.rbSumar.AutoSize = true;
            this.rbSumar.Location = new System.Drawing.Point(6, 28);
            this.rbSumar.Name = "rbSumar";
            this.rbSumar.Size = new System.Drawing.Size(67, 20);
            this.rbSumar.TabIndex = 4;
            this.rbSumar.TabStop = true;
            this.rbSumar.Text = "Sumar";
            this.rbSumar.UseVisualStyleBackColor = true;
            this.rbSumar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbRestar
            // 
            this.rbRestar.AutoSize = true;
            this.rbRestar.Location = new System.Drawing.Point(6, 54);
            this.rbRestar.Name = "rbRestar";
            this.rbRestar.Size = new System.Drawing.Size(68, 20);
            this.rbRestar.TabIndex = 5;
            this.rbRestar.TabStop = true;
            this.rbRestar.Text = "Restar";
            this.rbRestar.UseVisualStyleBackColor = true;
            this.rbRestar.CheckedChanged += new System.EventHandler(this.rbRestar_CheckedChanged);
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Location = new System.Drawing.Point(6, 80);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(88, 20);
            this.rbMultiplicar.TabIndex = 6;
            this.rbMultiplicar.TabStop = true;
            this.rbMultiplicar.Text = "Multiplicar";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            this.rbMultiplicar.CheckedChanged += new System.EventHandler(this.rbMultiplicar_CheckedChanged);
            // 
            // rbDividir
            // 
            this.rbDividir.AutoSize = true;
            this.rbDividir.Location = new System.Drawing.Point(6, 106);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(66, 20);
            this.rbDividir.TabIndex = 7;
            this.rbDividir.TabStop = true;
            this.rbDividir.Text = "Dividir";
            this.rbDividir.UseVisualStyleBackColor = true;
            this.rbDividir.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(28, 20);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(272, 16);
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "Ingresa los valores y selecciona una opción:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(167, 52);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(14, 16);
            this.lblOperador.TabIndex = 1;
            this.lblOperador.Text = "+";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(367, 49);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(14, 16);
            this.lblIgual.TabIndex = 2;
            this.lblIgual.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 264);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Name = "Form1";
            this.Text = "Practica de Estructura If";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.RadioButton rbSumar;
        private System.Windows.Forms.RadioButton rbRestar;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbDividir;
    }
}

