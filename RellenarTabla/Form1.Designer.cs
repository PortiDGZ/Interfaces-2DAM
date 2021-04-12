namespace RellenarTabla
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
            this.components = new System.ComponentModel.Container();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POBLACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alta_btn = new System.Windows.Forms.Button();
            this.baja_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.interfacesDataSet = new RellenarTabla.interfacesDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new RellenarTabla.interfacesDataSetTableAdapters.alumnosTableAdapter();
            this.accesobd_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.NOMBRE,
            this.APELLIDOS,
            this.CURSO,
            this.TELEFONO,
            this.PROVINCIA,
            this.POBLACION});
            this.tablaDatos.Location = new System.Drawing.Point(120, 148);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(749, 270);
            this.tablaDatos.TabIndex = 0;
            this.tablaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDatos_CellClick);
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.Name = "APELLIDOS";
            // 
            // CURSO
            // 
            this.CURSO.HeaderText = "CURSO";
            this.CURSO.Name = "CURSO";
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // PROVINCIA
            // 
            this.PROVINCIA.HeaderText = "PROVINCIA";
            this.PROVINCIA.Name = "PROVINCIA";
            // 
            // POBLACION
            // 
            this.POBLACION.HeaderText = "POBLACION";
            this.POBLACION.Name = "POBLACION";
            // 
            // alta_btn
            // 
            this.alta_btn.Location = new System.Drawing.Point(227, 60);
            this.alta_btn.Name = "alta_btn";
            this.alta_btn.Size = new System.Drawing.Size(75, 23);
            this.alta_btn.TabIndex = 1;
            this.alta_btn.Text = "ALTA";
            this.alta_btn.UseVisualStyleBackColor = true;
            this.alta_btn.Click += new System.EventHandler(this.alta_btn_Click);
            // 
            // baja_btn
            // 
            this.baja_btn.Location = new System.Drawing.Point(353, 60);
            this.baja_btn.Name = "baja_btn";
            this.baja_btn.Size = new System.Drawing.Size(75, 23);
            this.baja_btn.TabIndex = 2;
            this.baja_btn.Text = "BAJA";
            this.baja_btn.UseVisualStyleBackColor = true;
            this.baja_btn.Click += new System.EventHandler(this.baja_btn_Click);
            // 
            // modificar_btn
            // 
            this.modificar_btn.Location = new System.Drawing.Point(456, 60);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(75, 23);
            this.modificar_btn.TabIndex = 3;
            this.modificar_btn.Text = "MODIFICAR";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // interfacesDataSet
            // 
            this.interfacesDataSet.DataSetName = "interfacesDataSet";
            this.interfacesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.interfacesDataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // accesobd_btn
            // 
            this.accesobd_btn.Location = new System.Drawing.Point(692, 60);
            this.accesobd_btn.Name = "accesobd_btn";
            this.accesobd_btn.Size = new System.Drawing.Size(167, 23);
            this.accesobd_btn.TabIndex = 8;
            this.accesobd_btn.Text = "ACCESO CON BBDD";
            this.accesobd_btn.UseVisualStyleBackColor = true;
            this.accesobd_btn.Click += new System.EventHandler(this.accesobd_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.accesobd_btn);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.baja_btn);
            this.Controls.Add(this.alta_btn);
            this.Controls.Add(this.tablaDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn POBLACION;
        private System.Windows.Forms.Button alta_btn;
        private System.Windows.Forms.Button baja_btn;
        public System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button modificar_btn;
        private interfacesDataSet interfacesDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private interfacesDataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.Button accesobd_btn;
    }
}

