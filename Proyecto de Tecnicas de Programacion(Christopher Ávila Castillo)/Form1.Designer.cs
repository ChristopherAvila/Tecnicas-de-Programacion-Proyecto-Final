
namespace Proyecto_de_Tecnicas_de_Programacion_Christopher_Ávila_Castillo_
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_palco = new System.Windows.Forms.TextBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_sombra = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.lbl_palco = new System.Windows.Forms.Label();
            this.lbl_sombra = new System.Windows.Forms.Label();
            this.dg_lista = new System.Windows.Forms.DataGridView();
            this.btn_cargarlista = new System.Windows.Forms.Button();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_montototal = new System.Windows.Forms.Label();
            this.lbl_simbolocolones = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_factura = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_montomasiva = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_simbolocolones2 = new System.Windows.Forms.Label();
            this.btn_seleccionarclientes = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(368, 14);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(146, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_palco
            // 
            this.txt_palco.Location = new System.Drawing.Point(368, 104);
            this.txt_palco.Name = "txt_palco";
            this.txt_palco.Size = new System.Drawing.Size(146, 20);
            this.txt_palco.TabIndex = 1;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(368, 61);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(146, 20);
            this.txt_cedula.TabIndex = 2;
            // 
            // txt_sombra
            // 
            this.txt_sombra.Location = new System.Drawing.Point(368, 150);
            this.txt_sombra.Name = "txt_sombra";
            this.txt_sombra.Size = new System.Drawing.Size(146, 20);
            this.txt_sombra.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(28, 14);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 20);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre :";
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.Location = new System.Drawing.Point(28, 61);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(67, 20);
            this.lbl_cedula.TabIndex = 6;
            this.lbl_cedula.Text = "Cédula :";
            // 
            // lbl_palco
            // 
            this.lbl_palco.AutoSize = true;
            this.lbl_palco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_palco.Location = new System.Drawing.Point(28, 104);
            this.lbl_palco.Name = "lbl_palco";
            this.lbl_palco.Size = new System.Drawing.Size(312, 20);
            this.lbl_palco.TabIndex = 7;
            this.lbl_palco.Text = "Cantidad de Tiquetes de Palco que desea :";
            // 
            // lbl_sombra
            // 
            this.lbl_sombra.AutoSize = true;
            this.lbl_sombra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sombra.Location = new System.Drawing.Point(28, 150);
            this.lbl_sombra.Name = "lbl_sombra";
            this.lbl_sombra.Size = new System.Drawing.Size(330, 20);
            this.lbl_sombra.TabIndex = 8;
            this.lbl_sombra.Text = "Cantidad de tiquetes de  Gradería  (Sombra) :";
            // 
            // dg_lista
            // 
            this.dg_lista.AllowUserToAddRows = false;
            this.dg_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8});
            this.dg_lista.Location = new System.Drawing.Point(32, 277);
            this.dg_lista.Name = "dg_lista";
            this.dg_lista.RowHeadersVisible = false;
            this.dg_lista.Size = new System.Drawing.Size(1011, 183);
            this.dg_lista.TabIndex = 10;
            this.dg_lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lista_CellContentClick);
            // 
            // btn_cargarlista
            // 
            this.btn_cargarlista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cargarlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargarlista.Location = new System.Drawing.Point(32, 243);
            this.btn_cargarlista.Name = "btn_cargarlista";
            this.btn_cargarlista.Size = new System.Drawing.Size(129, 28);
            this.btn_cargarlista.TabIndex = 11;
            this.btn_cargarlista.Text = "Cargar Lista";
            this.btn_cargarlista.UseVisualStyleBackColor = false;
            this.btn_cargarlista.Click += new System.EventHandler(this.btn_cargarlista_Click);
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_monto.Location = new System.Drawing.Point(241, 194);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(55, 24);
            this.lbl_monto.TabIndex = 12;
            this.lbl_monto.Text = "00.00";
            // 
            // lbl_montototal
            // 
            this.lbl_montototal.AutoSize = true;
            this.lbl_montototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montototal.Location = new System.Drawing.Point(28, 194);
            this.lbl_montototal.Name = "lbl_montototal";
            this.lbl_montototal.Size = new System.Drawing.Size(192, 20);
            this.lbl_montototal.TabIndex = 13;
            this.lbl_montototal.Text = "Monto total de la compra :";
            // 
            // lbl_simbolocolones
            // 
            this.lbl_simbolocolones.AutoSize = true;
            this.lbl_simbolocolones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_simbolocolones.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_simbolocolones.Location = new System.Drawing.Point(218, 194);
            this.lbl_simbolocolones.Name = "lbl_simbolocolones";
            this.lbl_simbolocolones.Size = new System.Drawing.Size(24, 24);
            this.lbl_simbolocolones.TabIndex = 14;
            this.lbl_simbolocolones.Text = "₡";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(472, 220);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(168, 20);
            this.lbl_titulo.TabIndex = 15;
            this.lbl_titulo.Text = "Lista de ventas totales";
            // 
            // btn_factura
            // 
            this.btn_factura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factura.Location = new System.Drawing.Point(167, 243);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(129, 28);
            this.btn_factura.TabIndex = 16;
            this.btn_factura.Text = "Crear Factura";
            this.btn_factura.UseVisualStyleBackColor = false;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(720, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lbl_montomasiva
            // 
            this.lbl_montomasiva.AutoSize = true;
            this.lbl_montomasiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montomasiva.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_montomasiva.Location = new System.Drawing.Point(388, 194);
            this.lbl_montomasiva.Name = "lbl_montomasiva";
            this.lbl_montomasiva.Size = new System.Drawing.Size(55, 24);
            this.lbl_montomasiva.TabIndex = 18;
            this.lbl_montomasiva.Text = "00.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = " iva :";
            // 
            // lbl_simbolocolones2
            // 
            this.lbl_simbolocolones2.AutoSize = true;
            this.lbl_simbolocolones2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_simbolocolones2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_simbolocolones2.Location = new System.Drawing.Point(369, 194);
            this.lbl_simbolocolones2.Name = "lbl_simbolocolones2";
            this.lbl_simbolocolones2.Size = new System.Drawing.Size(24, 24);
            this.lbl_simbolocolones2.TabIndex = 20;
            this.lbl_simbolocolones2.Text = "₡";
            // 
            // btn_seleccionarclientes
            // 
            this.btn_seleccionarclientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_seleccionarclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionarclientes.Location = new System.Drawing.Point(302, 243);
            this.btn_seleccionarclientes.Name = "btn_seleccionarclientes";
            this.btn_seleccionarclientes.Size = new System.Drawing.Size(164, 28);
            this.btn_seleccionarclientes.TabIndex = 21;
            this.btn_seleccionarclientes.Text = "Seleccionar Clientes";
            this.btn_seleccionarclientes.UseVisualStyleBackColor = false;
            this.btn_seleccionarclientes.Click += new System.EventHandler(this.btn_seleccionarclientes_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cedula";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cantidad de boletos de Palco";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cantidad de Boletos de Sombra";
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo de los Boletos de Palco total";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Costo de los Boletos de Graderia total";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Monto";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "iva";
            this.Column8.Name = "Column8";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Location = new System.Drawing.Point(750, 40);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(164, 28);
            this.btn_borrar.TabIndex = 22;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.Location = new System.Drawing.Point(750, 142);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(164, 28);
            this.btn_ayuda.TabIndex = 23;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Presiona para aprender a usar el programa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_seleccionarclientes);
            this.Controls.Add(this.lbl_simbolocolones2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_montomasiva);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_simbolocolones);
            this.Controls.Add(this.lbl_montototal);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.btn_cargarlista);
            this.Controls.Add(this.dg_lista);
            this.Controls.Add(this.lbl_sombra);
            this.Controls.Add(this.lbl_palco);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_sombra);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.txt_palco);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form1";
            this.Text = "Boleteria";
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_palco;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_sombra;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_palco;
        private System.Windows.Forms.Label lbl_sombra;
        private System.Windows.Forms.DataGridView dg_lista;
        private System.Windows.Forms.Button btn_cargarlista;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_montototal;
        private System.Windows.Forms.Label lbl_simbolocolones;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_montomasiva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_simbolocolones2;
        private System.Windows.Forms.Button btn_seleccionarclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Label label1;
    }
}

