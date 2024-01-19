namespace EjerVisualC_1
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
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_itbis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio del Producto";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(15, 38);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(158, 20);
            this.txt_precio.TabIndex = 1;
            // 
            // txt_itbis
            // 
            this.txt_itbis.Enabled = false;
            this.txt_itbis.Location = new System.Drawing.Point(15, 84);
            this.txt_itbis.Name = "txt_itbis";
            this.txt_itbis.Size = new System.Drawing.Size(158, 20);
            this.txt_itbis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ITBIS";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(15, 134);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(158, 20);
            this.txt_total.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total a pagar";
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(216, 38);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_calcular.TabIndex = 6;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.Location = new System.Drawing.Point(216, 94);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpiar.TabIndex = 7;
            this.bt_limpiar.Text = "Limpiar";
            this.bt_limpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 170);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_itbis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_itbis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Button bt_limpiar;
    }
}

