namespace WindowsApp
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
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelClienteIndividuo = new System.Windows.Forms.Label();
            this.labelClienteEmpresa = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelFactura = new System.Windows.Forms.Label();
            this.labelRemito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(34, 39);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(50, 13);
            this.labelProducto.TabIndex = 0;
            this.labelProducto.Text = "Producto";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(379, 38);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(56, 13);
            this.labelProveedor.TabIndex = 1;
            this.labelProveedor.Text = "Proveedor";
            // 
            // labelClienteIndividuo
            // 
            this.labelClienteIndividuo.AutoSize = true;
            this.labelClienteIndividuo.Location = new System.Drawing.Point(683, 39);
            this.labelClienteIndividuo.Name = "labelClienteIndividuo";
            this.labelClienteIndividuo.Size = new System.Drawing.Size(85, 13);
            this.labelClienteIndividuo.TabIndex = 2;
            this.labelClienteIndividuo.Text = "Cliente Individuo";
            // 
            // labelClienteEmpresa
            // 
            this.labelClienteEmpresa.AutoSize = true;
            this.labelClienteEmpresa.Location = new System.Drawing.Point(985, 38);
            this.labelClienteEmpresa.Name = "labelClienteEmpresa";
            this.labelClienteEmpresa.Size = new System.Drawing.Size(83, 13);
            this.labelClienteEmpresa.TabIndex = 3;
            this.labelClienteEmpresa.Text = "Cliente Empresa";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(37, 349);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(53, 13);
            this.labelVendedor.TabIndex = 4;
            this.labelVendedor.Text = "Vendedor";
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Location = new System.Drawing.Point(379, 348);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(43, 13);
            this.labelFactura.TabIndex = 5;
            this.labelFactura.Text = "Factura";
            // 
            // labelRemito
            // 
            this.labelRemito.AutoSize = true;
            this.labelRemito.Location = new System.Drawing.Point(683, 348);
            this.labelRemito.Name = "labelRemito";
            this.labelRemito.Size = new System.Drawing.Size(40, 13);
            this.labelRemito.TabIndex = 6;
            this.labelRemito.Text = "Remito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 606);
            this.Controls.Add(this.labelRemito);
            this.Controls.Add(this.labelFactura);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(this.labelClienteEmpresa);
            this.Controls.Add(this.labelClienteIndividuo);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.labelProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelClienteIndividuo;
        private System.Windows.Forms.Label labelClienteEmpresa;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.Label labelRemito;
    }
}

