namespace GestionSeguros
{
    partial class inicio
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
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDataSet = new GestionSeguros.gestionDataSet();
            this.datosTableAdapter = new GestionSeguros.gestionDataSetTableAdapters.datosTableAdapter();
            this.alta_btn = new System.Windows.Forms.Button();
            this.baja_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDatos
            // 
            this.tablaDatos.AutoGenerateColumns = false;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.tablaDatos.DataSource = this.datosBindingSource;
            this.tablaDatos.Location = new System.Drawing.Point(112, 177);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(851, 203);
            this.tablaDatos.TabIndex = 0;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "C.P.";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataMember = "datos";
            this.datosBindingSource.DataSource = this.gestionDataSet;
            // 
            // gestionDataSet
            // 
            this.gestionDataSet.DataSetName = "gestionDataSet";
            this.gestionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosTableAdapter
            // 
            this.datosTableAdapter.ClearBeforeFill = true;
            // 
            // alta_btn
            // 
            this.alta_btn.Location = new System.Drawing.Point(261, 62);
            this.alta_btn.Name = "alta_btn";
            this.alta_btn.Size = new System.Drawing.Size(75, 23);
            this.alta_btn.TabIndex = 1;
            this.alta_btn.Text = "Alta";
            this.alta_btn.UseVisualStyleBackColor = true;
            // 
            // baja_btn
            // 
            this.baja_btn.Location = new System.Drawing.Point(542, 62);
            this.baja_btn.Name = "baja_btn";
            this.baja_btn.Size = new System.Drawing.Size(75, 23);
            this.baja_btn.TabIndex = 2;
            this.baja_btn.Text = "Baja";
            this.baja_btn.UseVisualStyleBackColor = true;
            this.baja_btn.Click += new System.EventHandler(this.baja_btn_Click);
            // 
            // mod_btn
            // 
            this.mod_btn.Location = new System.Drawing.Point(781, 62);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(75, 23);
            this.mod_btn.TabIndex = 3;
            this.mod_btn.Text = "Modificación";
            this.mod_btn.UseVisualStyleBackColor = true;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.mod_btn);
            this.Controls.Add(this.baja_btn);
            this.Controls.Add(this.alta_btn);
            this.Controls.Add(this.tablaDatos);
            this.Name = "inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDatos;
        private gestionDataSet gestionDataSet;
        private System.Windows.Forms.BindingSource datosBindingSource;
        private gestionDataSetTableAdapters.datosTableAdapter datosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button alta_btn;
        private System.Windows.Forms.Button baja_btn;
        private System.Windows.Forms.Button mod_btn;
    }
}