namespace WindowsForms40
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
            this.button1GenerarLlamada = new System.Windows.Forms.Button();
            this.button1FacturacionTotal = new System.Windows.Forms.Button();
            this.button2FacturacionLocal = new System.Windows.Forms.Button();
            this.button3FacturacionProvincial = new System.Windows.Forms.Button();
            this.button1Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1GenerarLlamada
            // 
            this.button1GenerarLlamada.Location = new System.Drawing.Point(9, 11);
            this.button1GenerarLlamada.Name = "button1GenerarLlamada";
            this.button1GenerarLlamada.Size = new System.Drawing.Size(256, 64);
            this.button1GenerarLlamada.TabIndex = 0;
            this.button1GenerarLlamada.Text = "Generar Llamada";
            this.button1GenerarLlamada.UseVisualStyleBackColor = true;
            this.button1GenerarLlamada.Click += new System.EventHandler(this.button1GenerarLlamada_Click);
            // 
            // button1FacturacionTotal
            // 
            this.button1FacturacionTotal.Location = new System.Drawing.Point(8, 81);
            this.button1FacturacionTotal.Name = "button1FacturacionTotal";
            this.button1FacturacionTotal.Size = new System.Drawing.Size(256, 64);
            this.button1FacturacionTotal.TabIndex = 1;
            this.button1FacturacionTotal.Text = "Facturacion Total";
            this.button1FacturacionTotal.UseVisualStyleBackColor = true;
            // 
            // button2FacturacionLocal
            // 
            this.button2FacturacionLocal.Location = new System.Drawing.Point(9, 151);
            this.button2FacturacionLocal.Name = "button2FacturacionLocal";
            this.button2FacturacionLocal.Size = new System.Drawing.Size(256, 64);
            this.button2FacturacionLocal.TabIndex = 2;
            this.button2FacturacionLocal.Text = "Facturacion Local";
            this.button2FacturacionLocal.UseVisualStyleBackColor = true;
            // 
            // button3FacturacionProvincial
            // 
            this.button3FacturacionProvincial.Location = new System.Drawing.Point(8, 221);
            this.button3FacturacionProvincial.Name = "button3FacturacionProvincial";
            this.button3FacturacionProvincial.Size = new System.Drawing.Size(256, 64);
            this.button3FacturacionProvincial.TabIndex = 3;
            this.button3FacturacionProvincial.Text = "Facturacion Provincial";
            this.button3FacturacionProvincial.UseVisualStyleBackColor = true;
            // 
            // button1Salir
            // 
            this.button1Salir.Location = new System.Drawing.Point(9, 291);
            this.button1Salir.Name = "button1Salir";
            this.button1Salir.Size = new System.Drawing.Size(256, 64);
            this.button1Salir.TabIndex = 4;
            this.button1Salir.Text = "Salir";
            this.button1Salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 365);
            this.Controls.Add(this.button1Salir);
            this.Controls.Add(this.button3FacturacionProvincial);
            this.Controls.Add(this.button2FacturacionLocal);
            this.Controls.Add(this.button1FacturacionTotal);
            this.Controls.Add(this.button1GenerarLlamada);
            this.Name = "Form1";
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1GenerarLlamada;
        private System.Windows.Forms.Button button1FacturacionTotal;
        private System.Windows.Forms.Button button2FacturacionLocal;
        private System.Windows.Forms.Button button3FacturacionProvincial;
        private System.Windows.Forms.Button button1Salir;
    }
}

