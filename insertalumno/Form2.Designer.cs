namespace insertalumno
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interfacesDataSet1 = new insertalumno.interfacesDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.municipiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interfacesDataSet = new insertalumno.interfacesDataSet();
            this.municipiosTableAdapter = new insertalumno.interfacesDataSetTableAdapters.municipiosTableAdapter();
            this.tableAdapterManager = new insertalumno.interfacesDataSetTableAdapters.TableAdapterManager();
            this.alumnosTableAdapter = new insertalumno.interfacesDataSet1TableAdapters.alumnosTableAdapter();
            this.tableAdapterManager1 = new insertalumno.interfacesDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.poblaciónDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // idalumnoDataGridViewTextBoxColumn
            // 
            this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.HeaderText = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
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
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // poblaciónDataGridViewTextBoxColumn
            // 
            this.poblaciónDataGridViewTextBoxColumn.DataPropertyName = "población";
            this.poblaciónDataGridViewTextBoxColumn.HeaderText = "población";
            this.poblaciónDataGridViewTextBoxColumn.Name = "poblaciónDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insertar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Recargar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // municipiosBindingSource
            // 
            this.municipiosBindingSource.DataMember = "municipios";
            this.municipiosBindingSource.DataSource = this.interfacesDataSet;
            // 
            // interfacesDataSet
            // 
            this.interfacesDataSet.DataSetName = "interfacesDataSet";
            this.interfacesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // municipiosTableAdapter
            // 
            this.municipiosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.municipiosTableAdapter = this.municipiosTableAdapter;
            this.tableAdapterManager.provinciasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = insertalumno.interfacesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.alumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.municipiosTableAdapter = null;
            this.tableAdapterManager1.provinciasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = insertalumno.interfacesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private interfacesDataSet interfacesDataSet;
        private System.Windows.Forms.BindingSource municipiosBindingSource;
        private interfacesDataSetTableAdapters.municipiosTableAdapter municipiosTableAdapter;
        private interfacesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private interfacesDataSet1 interfacesDataSet1;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private interfacesDataSet1TableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private interfacesDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
    }
}