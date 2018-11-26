namespace TiendaEscritorio
{
    partial class AdicionarVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.txtNombrePventa = new System.Windows.Forms.TextBox();
            this.txtcantidadVenta = new System.Windows.Forms.TextBox();
            this.txtTventa = new System.Windows.Forms.TextBox();
            this.TotalVenta = new System.Windows.Forms.Label();
            this.mostrarVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Del Producto";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(106, 227);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarVenta.TabIndex = 4;
            this.btnRegistrarVenta.Text = "Registar";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // txtNombrePventa
            // 
            this.txtNombrePventa.Location = new System.Drawing.Point(195, 51);
            this.txtNombrePventa.Name = "txtNombrePventa";
            this.txtNombrePventa.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePventa.TabIndex = 5;
            // 
            // txtcantidadVenta
            // 
            this.txtcantidadVenta.Location = new System.Drawing.Point(195, 102);
            this.txtcantidadVenta.Name = "txtcantidadVenta";
            this.txtcantidadVenta.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadVenta.TabIndex = 6;
            // 
            // txtTventa
            // 
            this.txtTventa.Location = new System.Drawing.Point(195, 164);
            this.txtTventa.Name = "txtTventa";
            this.txtTventa.Size = new System.Drawing.Size(100, 20);
            this.txtTventa.TabIndex = 7;
            // 
            // TotalVenta
            // 
            this.TotalVenta.AutoSize = true;
            this.TotalVenta.Location = new System.Drawing.Point(42, 167);
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.Size = new System.Drawing.Size(31, 13);
            this.TotalVenta.TabIndex = 13;
            this.TotalVenta.Text = "Total";
            // 
            // mostrarVenta
            // 
            this.mostrarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarVenta.Location = new System.Drawing.Point(339, 34);
            this.mostrarVenta.Name = "mostrarVenta";
            this.mostrarVenta.Size = new System.Drawing.Size(470, 238);
            this.mostrarVenta.TabIndex = 14;
            // 
            // AdicionarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(821, 284);
            this.Controls.Add(this.mostrarVenta);
            this.Controls.Add(this.TotalVenta);
            this.Controls.Add(this.txtTventa);
            this.Controls.Add(this.txtcantidadVenta);
            this.Controls.Add(this.txtNombrePventa);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarVenta";
            this.Text = "AdicionarVenta";
            this.Load += new System.EventHandler(this.AdicionarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.TextBox txtNombrePventa;
        private System.Windows.Forms.TextBox txtcantidadVenta;
        private System.Windows.Forms.TextBox txtTventa;
        private System.Windows.Forms.Label TotalVenta;
        private System.Windows.Forms.DataGridView mostrarVenta;
    }
}