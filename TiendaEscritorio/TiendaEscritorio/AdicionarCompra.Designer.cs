namespace TiendaEscritorio
{
    partial class AdicionarCompra
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.txtNombrePCompra = new System.Windows.Forms.TextBox();
            this.txtCantidadCompra = new System.Windows.Forms.TextBox();
            this.datetimeCompra = new System.Windows.Forms.DateTimePicker();
            this.mostrarcompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarcompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Compra";
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Location = new System.Drawing.Point(122, 243);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarCompra.TabIndex = 4;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // txtNombrePCompra
            // 
            this.txtNombrePCompra.Location = new System.Drawing.Point(195, 49);
            this.txtNombrePCompra.Name = "txtNombrePCompra";
            this.txtNombrePCompra.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePCompra.TabIndex = 5;
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Location = new System.Drawing.Point(195, 104);
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadCompra.TabIndex = 6;
            // 
            // datetimeCompra
            // 
            this.datetimeCompra.Location = new System.Drawing.Point(122, 170);
            this.datetimeCompra.Name = "datetimeCompra";
            this.datetimeCompra.Size = new System.Drawing.Size(200, 20);
            this.datetimeCompra.TabIndex = 12;
            // 
            // mostrarcompra
            // 
            this.mostrarcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarcompra.Location = new System.Drawing.Point(357, 49);
            this.mostrarcompra.Name = "mostrarcompra";
            this.mostrarcompra.Size = new System.Drawing.Size(458, 217);
            this.mostrarcompra.TabIndex = 13;
            // 
            // AdicionarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(827, 290);
            this.Controls.Add(this.mostrarcompra);
            this.Controls.Add(this.datetimeCompra);
            this.Controls.Add(this.txtCantidadCompra);
            this.Controls.Add(this.txtNombrePCompra);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarCompra";
            this.Text = "AdicionarCompra";
            this.Load += new System.EventHandler(this.AdicionarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarcompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.TextBox txtNombrePCompra;
        private System.Windows.Forms.TextBox txtCantidadCompra;
        private System.Windows.Forms.DateTimePicker datetimeCompra;
        private System.Windows.Forms.DataGridView mostrarcompra;
    }
}