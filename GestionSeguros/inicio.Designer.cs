﻿namespace GestionSeguros
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
            this.alta_btn = new System.Windows.Forms.Button();
            this.baja_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencia_segurosDataSet1 = new GestionSeguros.agencia_segurosDataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new GestionSeguros.agencia_segurosDataSet1TableAdapters.clienteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // alta_btn
            // 
            this.alta_btn.Location = new System.Drawing.Point(43, 53);
            this.alta_btn.Name = "alta_btn";
            this.alta_btn.Size = new System.Drawing.Size(75, 23);
            this.alta_btn.TabIndex = 1;
            this.alta_btn.Text = "Alta";
            this.alta_btn.UseVisualStyleBackColor = true;
            this.alta_btn.Click += new System.EventHandler(this.alta_btn_Click);
            // 
            // baja_btn
            // 
            this.baja_btn.Location = new System.Drawing.Point(167, 53);
            this.baja_btn.Name = "baja_btn";
            this.baja_btn.Size = new System.Drawing.Size(75, 23);
            this.baja_btn.TabIndex = 2;
            this.baja_btn.Text = "Baja";
            this.baja_btn.UseVisualStyleBackColor = true;
            this.baja_btn.Click += new System.EventHandler(this.baja_btn_Click);
            // 
            // mod_btn
            // 
            this.mod_btn.Location = new System.Drawing.Point(285, 53);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(75, 23);
            this.mod_btn.TabIndex = 3;
            this.mod_btn.Text = "Modificación";
            this.mod_btn.UseVisualStyleBackColor = true;
            // 
            // tablaDatos
            // 
            this.tablaDatos.AutoGenerateColumns = false;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.tipoclienteDataGridViewTextBoxColumn});
            this.tablaDatos.DataSource = this.clienteBindingSource;
            this.tablaDatos.Location = new System.Drawing.Point(29, 102);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(847, 252);
            this.tablaDatos.TabIndex = 4;
            this.tablaDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDatos_CellContentDoubleClick);
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            // 
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // tipoclienteDataGridViewTextBoxColumn
            // 
            this.tipoclienteDataGridViewTextBoxColumn.DataPropertyName = "Tipo_cliente";
            this.tipoclienteDataGridViewTextBoxColumn.HeaderText = "Tipo de cliente";
            this.tipoclienteDataGridViewTextBoxColumn.Name = "tipoclienteDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.agencia_segurosDataSet1;
            // 
            // agencia_segurosDataSet1
            // 
            this.agencia_segurosDataSet1.DataSetName = "agencia_segurosDataSet1";
            this.agencia_segurosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Búsqueda:";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.mod_btn);
            this.Controls.Add(this.baja_btn);
            this.Controls.Add(this.alta_btn);
            this.Name = "inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button alta_btn;
        private System.Windows.Forms.Button baja_btn;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private agencia_segurosDataSet1 agencia_segurosDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private agencia_segurosDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoclienteDataGridViewTextBoxColumn;
    }
}