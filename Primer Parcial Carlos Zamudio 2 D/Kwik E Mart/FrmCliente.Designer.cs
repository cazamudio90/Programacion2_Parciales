namespace Kwik_E_Mart
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.btnAceptarVenta = new System.Windows.Forms.Button();
            this.chbExisteCliente = new System.Windows.Forms.CheckBox();
            this.lblClienteExistente = new System.Windows.Forms.Label();
            this.lblClienteEnBase = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnAceptarCliente = new System.Windows.Forms.Button();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.lblListaDeProductos = new System.Windows.Forms.Label();
            this.nUpDUnidades = new System.Windows.Forms.NumericUpDown();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.btnAgregarProdVenta = new System.Windows.Forms.Button();
            this.dgvProductoVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreCliente.Location = new System.Drawing.Point(106, 82);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(87, 25);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblApellidoCliente.Location = new System.Drawing.Point(106, 156);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(89, 25);
            this.lblApellidoCliente.TabIndex = 1;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDniCliente.Location = new System.Drawing.Point(146, 222);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(47, 25);
            this.lblDniCliente.TabIndex = 2;
            this.lblDniCliente.Text = "DNI";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(228, 79);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(163, 31);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(228, 150);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(163, 31);
            this.txtApellidoCliente.TabIndex = 4;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCliente.Location = new System.Drawing.Point(228, 222);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(163, 31);
            this.txtDniCliente.TabIndex = 5;
            // 
            // btnAceptarVenta
            // 
            this.btnAceptarVenta.Location = new System.Drawing.Point(676, 319);
            this.btnAceptarVenta.Name = "btnAceptarVenta";
            this.btnAceptarVenta.Size = new System.Drawing.Size(143, 34);
            this.btnAceptarVenta.TabIndex = 6;
            this.btnAceptarVenta.Text = "Aceptar";
            this.btnAceptarVenta.UseVisualStyleBackColor = true;
            this.btnAceptarVenta.Click += new System.EventHandler(this.btnAceptarCliente_Click);
            // 
            // chbExisteCliente
            // 
            this.chbExisteCliente.AutoSize = true;
            this.chbExisteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExisteCliente.Location = new System.Drawing.Point(228, 290);
            this.chbExisteCliente.Name = "chbExisteCliente";
            this.chbExisteCliente.Size = new System.Drawing.Size(15, 14);
            this.chbExisteCliente.TabIndex = 7;
            this.chbExisteCliente.UseVisualStyleBackColor = true;
            this.chbExisteCliente.CheckedChanged += new System.EventHandler(this.chbExisteCliente_CheckedChanged);
            // 
            // lblClienteExistente
            // 
            this.lblClienteExistente.AutoSize = true;
            this.lblClienteExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteExistente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClienteExistente.Location = new System.Drawing.Point(21, 284);
            this.lblClienteExistente.Name = "lblClienteExistente";
            this.lblClienteExistente.Size = new System.Drawing.Size(174, 25);
            this.lblClienteExistente.TabIndex = 8;
            this.lblClienteExistente.Text = "Cliente Existente";
            // 
            // lblClienteEnBase
            // 
            this.lblClienteEnBase.AutoSize = true;
            this.lblClienteEnBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteEnBase.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClienteEnBase.Location = new System.Drawing.Point(522, 82);
            this.lblClienteEnBase.Name = "lblClienteEnBase";
            this.lblClienteEnBase.Size = new System.Drawing.Size(79, 25);
            this.lblClienteEnBase.TabIndex = 9;
            this.lblClienteEnBase.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(646, 79);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(152, 33);
            this.cbCliente.TabIndex = 10;
            // 
            // btnAceptarCliente
            // 
            this.btnAceptarCliente.Location = new System.Drawing.Point(248, 328);
            this.btnAceptarCliente.Name = "btnAceptarCliente";
            this.btnAceptarCliente.Size = new System.Drawing.Size(143, 34);
            this.btnAceptarCliente.TabIndex = 11;
            this.btnAceptarCliente.Text = "Aceptar";
            this.btnAceptarCliente.UseVisualStyleBackColor = true;
            this.btnAceptarCliente.Click += new System.EventHandler(this.btnAceptarCliente_Click_1);
            // 
            // cbProductos
            // 
            this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(646, 148);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(186, 33);
            this.cbProductos.TabIndex = 13;
            // 
            // lblListaDeProductos
            // 
            this.lblListaDeProductos.AutoSize = true;
            this.lblListaDeProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeProductos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblListaDeProductos.Location = new System.Drawing.Point(522, 151);
            this.lblListaDeProductos.Name = "lblListaDeProductos";
            this.lblListaDeProductos.Size = new System.Drawing.Size(109, 25);
            this.lblListaDeProductos.TabIndex = 12;
            this.lblListaDeProductos.Text = "Productos";
            // 
            // nUpDUnidades
            // 
            this.nUpDUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDUnidades.Location = new System.Drawing.Point(646, 206);
            this.nUpDUnidades.Name = "nUpDUnidades";
            this.nUpDUnidades.Size = new System.Drawing.Size(70, 31);
            this.nUpDUnidades.TabIndex = 14;
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnidades.Location = new System.Drawing.Point(522, 212);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(103, 25);
            this.lblUnidades.TabIndex = 15;
            this.lblUnidades.Text = "Unidades";
            // 
            // btnAgregarProdVenta
            // 
            this.btnAgregarProdVenta.Location = new System.Drawing.Point(746, 206);
            this.btnAgregarProdVenta.Name = "btnAgregarProdVenta";
            this.btnAgregarProdVenta.Size = new System.Drawing.Size(134, 31);
            this.btnAgregarProdVenta.TabIndex = 16;
            this.btnAgregarProdVenta.Text = "Agregar Producto";
            this.btnAgregarProdVenta.UseVisualStyleBackColor = true;
            this.btnAgregarProdVenta.Click += new System.EventHandler(this.btnAgregarProdVenta_Click);
            // 
            // dgvProductoVentas
            // 
            this.dgvProductoVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductoVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvProductoVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductoVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductoVentas.EnableHeadersVisualStyles = false;
            this.dgvProductoVentas.Location = new System.Drawing.Point(901, 28);
            this.dgvProductoVentas.Name = "dgvProductoVentas";
            this.dgvProductoVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductoVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductoVentas.Size = new System.Drawing.Size(267, 333);
            this.dgvProductoVentas.TabIndex = 17;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1188, 390);
            this.Controls.Add(this.dgvProductoVentas);
            this.Controls.Add(this.btnAgregarProdVenta);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.nUpDUnidades);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.lblListaDeProductos);
            this.Controls.Add(this.btnAceptarCliente);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblClienteEnBase);
            this.Controls.Add(this.lblClienteExistente);
            this.Controls.Add(this.chbExisteCliente);
            this.Controls.Add(this.btnAceptarVenta);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Button btnAceptarVenta;
        private System.Windows.Forms.CheckBox chbExisteCliente;
        private System.Windows.Forms.Label lblClienteExistente;
        private System.Windows.Forms.Label lblClienteEnBase;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnAceptarCliente;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label lblListaDeProductos;
        private System.Windows.Forms.NumericUpDown nUpDUnidades;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Button btnAgregarProdVenta;
        private System.Windows.Forms.DataGridView dgvProductoVentas;
    }
}