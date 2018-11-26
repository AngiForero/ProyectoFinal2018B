namespace TiendaEscritorio
{
    partial class AdicionarProducto
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
            this.txtNProducto = new System.Windows.Forms.TextBox();
            this.txtVProducto = new System.Windows.Forms.TextBox();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.mostrarpro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarpro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Del Producto";
            // 
            // txtNProducto
            // 
            this.txtNProducto.Location = new System.Drawing.Point(177, 63);
            this.txtNProducto.Name = "txtNProducto";
            this.txtNProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNProducto.TabIndex = 2;
            // 
            // txtVProducto
            // 
            this.txtVProducto.Location = new System.Drawing.Point(177, 111);
            this.txtVProducto.Name = "txtVProducto";
            this.txtVProducto.Size = new System.Drawing.Size(100, 20);
            this.txtVProducto.TabIndex = 3;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(99, 211);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarProducto.TabIndex = 4;
            this.btnRegistrarProducto.Text = "Registrar";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad del producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(177, 160);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // mostrarpro
            // 
            this.mostrarpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarpro.Location = new System.Drawing.Point(333, 45);
            this.mostrarpro.Name = "mostrarpro";
            this.mostrarpro.Size = new System.Drawing.Size(397, 199);
            this.mostrarpro.TabIndex = 8;
            // 
            // AdicionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(742, 272);
            this.Controls.Add(this.mostrarpro);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrarProducto);
            this.Controls.Add(this.txtVProducto);
            this.Controls.Add(this.txtNProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarProducto";
            this.Text = "AdicionarProducto";
            this.Load += new System.EventHandler(this.AdicionarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNProducto;
        private System.Windows.Forms.TextBox txtVProducto;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView mostrarpro;
    }
}