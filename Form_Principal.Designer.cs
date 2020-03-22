namespace Placas
{
    partial class Form_Principal
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
            this.btn_cargar = new System.Windows.Forms.Button();
            this.pb_original = new System.Windows.Forms.PictureBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.dt = new System.Windows.Forms.DataGridView();
            this.btn_productos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fecha_entrada = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblDatosIngreso = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ticket = new System.Windows.Forms.TextBox();
            this.btn_conductores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(93, 277);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(98, 29);
            this.btn_cargar.TabIndex = 0;
            this.btn_cargar.Text = "Cargar Imagen";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // pb_original
            // 
            this.pb_original.Location = new System.Drawing.Point(12, 12);
            this.pb_original.Name = "pb_original";
            this.pb_original.Size = new System.Drawing.Size(273, 259);
            this.pb_original.TabIndex = 1;
            this.pb_original.TabStop = false;
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(323, 104);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Placa Encontrada:";
            // 
            // openFD
            // 
            this.openFD.Title = "seleccionar imagen";
            // 
            // dt
            // 
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(660, 28);
            this.dt.Name = "dt";
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.Size = new System.Drawing.Size(562, 323);
            this.dt.TabIndex = 10;
            this.dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalle);
            // 
            // btn_productos
            // 
            this.btn_productos.Location = new System.Drawing.Point(660, 357);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(75, 23);
            this.btn_productos.TabIndex = 11;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Entrada";
            // 
            // txt_fecha_entrada
            // 
            this.txt_fecha_entrada.Location = new System.Drawing.Point(460, 104);
            this.txt_fecha_entrada.Name = "txt_fecha_entrada";
            this.txt_fecha_entrada.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_entrada.TabIndex = 15;
            // 
            // txt_codigo
            // 
            this.txt_codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_codigo.Location = new System.Drawing.Point(331, 152);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 18;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Producto:";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(410, 293);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 20;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(337, 346);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(253, 44);
            this.btn_enviar.TabIndex = 22;
            this.btn_enviar.Text = "enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cedula Conductor:";
            // 
            // txt_cedula
            // 
            this.txt_cedula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_cedula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cedula.Location = new System.Drawing.Point(331, 208);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 25;
            this.txt_cedula.TextChanged += new System.EventHandler(this.txt_cedula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre Conductor:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(460, 208);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 23;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.Transparent;
            this.lblKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKg.Location = new System.Drawing.Point(449, 316);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(20, 13);
            this.lblKg.TabIndex = 29;
            this.lblKg.Text = "Kg";
            // 
            // lblDatosIngreso
            // 
            this.lblDatosIngreso.AutoSize = true;
            this.lblDatosIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDatosIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatosIngreso.Location = new System.Drawing.Point(407, 277);
            this.lblDatosIngreso.Name = "lblDatosIngreso";
            this.lblDatosIngreso.Size = new System.Drawing.Size(88, 13);
            this.lblDatosIngreso.TabIndex = 27;
            this.lblDatosIngreso.Text = "PESO BASCULA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ticket N°";
            // 
            // txt_ticket
            // 
            this.txt_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ticket.Location = new System.Drawing.Point(411, 37);
            this.txt_ticket.Name = "txt_ticket";
            this.txt_ticket.Size = new System.Drawing.Size(50, 31);
            this.txt_ticket.TabIndex = 30;
            // 
            // btn_conductores
            // 
            this.btn_conductores.Location = new System.Drawing.Point(741, 357);
            this.btn_conductores.Name = "btn_conductores";
            this.btn_conductores.Size = new System.Drawing.Size(75, 23);
            this.btn_conductores.TabIndex = 32;
            this.btn_conductores.Text = "Conductores";
            this.btn_conductores.UseVisualStyleBackColor = true;
            this.btn_conductores.Click += new System.EventHandler(this.btn_conductores_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre Producto:";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Location = new System.Drawing.Point(460, 150);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_producto.TabIndex = 33;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.btn_conductores);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ticket);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblDatosIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_fecha_entrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.pb_original);
            this.Controls.Add(this.btn_cargar);
            this.Name = "Form_Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.PictureBox pb_original;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fecha_entrada;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblDatosIngreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ticket;
        private System.Windows.Forms.Button btn_conductores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_producto;
    }
}

