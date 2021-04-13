namespace RellenarTabla
{
    partial class DataGridBBDD
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
            this.components = new System.ComponentModel.Container();
            this.interfacesDataSet = new RellenarTabla.interfacesDataSet();
            this.interfacesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alta_btn = new System.Windows.Forms.Button();
            this.baja_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interfacesDataSet1 = new RellenarTabla.interfacesDataSet1();
            this.alumnosTableAdapter = new RellenarTabla.interfacesDataSet1TableAdapters.alumnosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // interfacesDataSet
            // 
            this.interfacesDataSet.DataSetName = "interfacesDataSet";
            this.interfacesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // interfacesDataSetBindingSource
            // 
            this.interfacesDataSetBindingSource.DataSource = this.interfacesDataSet;
            this.interfacesDataSetBindingSource.Position = 0;
            // 
            // alta_btn
            // 
            this.alta_btn.Location = new System.Drawing.Point(424, 61);
            this.alta_btn.Name = "alta_btn";
            this.alta_btn.Size = new System.Drawing.Size(75, 23);
            this.alta_btn.TabIndex = 2;
            this.alta_btn.Text = "ALTA";
            this.alta_btn.UseVisualStyleBackColor = true;
            this.alta_btn.Click += new System.EventHandler(this.alta_btn_Click);
            // 
            // baja_btn
            // 
            this.baja_btn.Location = new System.Drawing.Point(575, 61);
            this.baja_btn.Name = "baja_btn";
            this.baja_btn.Size = new System.Drawing.Size(75, 23);
            this.baja_btn.TabIndex = 3;
            this.baja_btn.Text = "BAJA";
            this.baja_btn.UseVisualStyleBackColor = true;
            this.baja_btn.Click += new System.EventHandler(this.baja_btn_Click);
            // 
            // mod_btn
            // 
            this.mod_btn.Location = new System.Drawing.Point(747, 61);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(95, 23);
            this.mod_btn.TabIndex = 4;
            this.mod_btn.Text = "MODIFICACIÓN";
            this.mod_btn.UseVisualStyleBackColor = true;
            this.mod_btn.Click += new System.EventHandler(this.mod_btn_Click);
            // 
            // tablaDatos
            // 
            this.tablaDatos.AutoGenerateColumns = false;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.poblacionDataGridViewTextBoxColumn});
            this.tablaDatos.DataSource = this.alumnosBindingSource;
            this.tablaDatos.Location = new System.Drawing.Point(176, 202);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(755, 177);
            this.tablaDatos.TabIndex = 5;
            this.tablaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDatos_CellClick);
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // poblacionDataGridViewTextBoxColumn
            // 
            this.poblacionDataGridViewTextBoxColumn.DataPropertyName = "poblacion";
            this.poblacionDataGridViewTextBoxColumn.HeaderText = "poblacion";
            this.poblacionDataGridViewTextBoxColumn.Name = "poblacionDataGridViewTextBoxColumn";
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.interfacesDataSet1;
            // 
            // interfacesDataSet1
            // 
            this.interfacesDataSet1.DataSetName = "interfacesDataSet1";
            this.interfacesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 450);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.mod_btn);
            this.Controls.Add(this.baja_btn);
            this.Controls.Add(this.alta_btn);
            this.Name = "DataGridBBDD";
            this.Text = "DataGridBBDD";
            this.Load += new System.EventHandler(this.DataGridBBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private interfacesDataSet interfacesDataSet;
        private System.Windows.Forms.BindingSource interfacesDataSetBindingSource;
        private interfacesDataSet1 interfacesDataSet1;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private interfacesDataSet1TableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.Button alta_btn;
        private System.Windows.Forms.Button baja_btn;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacionDataGridViewTextBoxColumn;
    }
}