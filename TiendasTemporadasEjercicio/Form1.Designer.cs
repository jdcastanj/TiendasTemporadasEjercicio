namespace TiendasTemporadasEjercicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbescolar = new System.Windows.Forms.RadioButton();
            this.rbhalloween = new System.Windows.Forms.RadioButton();
            this.rbnavidad = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btnborrar = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de precio compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(45, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el valor de su compra:";
            // 
            // txtcompra
            // 
            this.txtcompra.Location = new System.Drawing.Point(404, 70);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(100, 26);
            this.txtcompra.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(875, 70);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(166, 111);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular precio";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbnavidad);
            this.gb1.Controls.Add(this.rbhalloween);
            this.gb1.Controls.Add(this.rbescolar);
            this.gb1.Location = new System.Drawing.Point(555, 70);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(243, 126);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "Temporada";
            // 
            // rbescolar
            // 
            this.rbescolar.AutoSize = true;
            this.rbescolar.Location = new System.Drawing.Point(23, 26);
            this.rbescolar.Name = "rbescolar";
            this.rbescolar.Size = new System.Drawing.Size(87, 24);
            this.rbescolar.TabIndex = 0;
            this.rbescolar.TabStop = true;
            this.rbescolar.Text = "Escolar";
            this.rbescolar.UseVisualStyleBackColor = true;
            // 
            // rbhalloween
            // 
            this.rbhalloween.AutoSize = true;
            this.rbhalloween.Location = new System.Drawing.Point(23, 56);
            this.rbhalloween.Name = "rbhalloween";
            this.rbhalloween.Size = new System.Drawing.Size(108, 24);
            this.rbhalloween.TabIndex = 1;
            this.rbhalloween.TabStop = true;
            this.rbhalloween.Text = "Halloween";
            this.rbhalloween.UseVisualStyleBackColor = true;
            // 
            // rbnavidad
            // 
            this.rbnavidad.AutoSize = true;
            this.rbnavidad.Location = new System.Drawing.Point(23, 87);
            this.rbnavidad.Name = "rbnavidad";
            this.rbnavidad.Size = new System.Drawing.Size(91, 24);
            this.rbnavidad.TabIndex = 2;
            this.rbnavidad.TabStop = true;
            this.rbnavidad.Text = "Navidad";
            this.rbnavidad.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descuento:";
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldescuento.Location = new System.Drawing.Point(189, 22);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(113, 29);
            this.lbldescuento.TabIndex = 6;
            this.lbldescuento.Text = "resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(21, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor a pagar:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblvalor.Location = new System.Drawing.Point(189, 72);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(113, 29);
            this.lblvalor.TabIndex = 8;
            this.lblvalor.Text = "resultado";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.lbldescuento);
            this.gb2.Controls.Add(this.lblvalor);
            this.gb2.Controls.Add(this.label3);
            this.gb2.Controls.Add(this.label5);
            this.gb2.Location = new System.Drawing.Point(25, 240);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(479, 131);
            this.gb2.TabIndex = 9;
            this.gb2.TabStop = false;
            this.gb2.Text = "groupBox1";
            this.gb2.Visible = false;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(857, 240);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(166, 111);
            this.btnborrar.TabIndex = 10;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtcompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Precios";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rbnavidad;
        private System.Windows.Forms.RadioButton rbhalloween;
        private System.Windows.Forms.RadioButton rbescolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnborrar;
    }
}

