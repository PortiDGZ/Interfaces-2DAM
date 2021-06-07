namespace GestionSeguros
{
    partial class poliza
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
            this.agencia_segurosDataSet = new GestionSeguros.agencia_segurosDataSet();
            this.agenciasegurosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new GestionSeguros.agencia_segurosDataSetTableAdapters.usuarioTableAdapter();
            this.agenciasegurosDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasegurosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasegurosDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.agenciasegurosDataSetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(61, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // agencia_segurosDataSet
            // 
            this.agencia_segurosDataSet.DataSetName = "agencia_segurosDataSet";
            this.agencia_segurosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agenciasegurosDataSetBindingSource
            // 
            this.agenciasegurosDataSetBindingSource.DataSource = this.agencia_segurosDataSet;
            this.agenciasegurosDataSetBindingSource.Position = 0;
            this.agenciasegurosDataSetBindingSource.CurrentChanged += new System.EventHandler(this.agenciasegurosDataSetBindingSource_CurrentChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.agenciasegurosDataSetBindingSource;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // agenciasegurosDataSetBindingSource1
            // 
            this.agenciasegurosDataSetBindingSource1.DataSource = this.agencia_segurosDataSet;
            this.agenciasegurosDataSetBindingSource1.Position = 0;
            // 
            // poliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "poliza";
            this.Text = "poliza";
            this.Load += new System.EventHandler(this.poliza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasegurosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasegurosDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource agenciasegurosDataSetBindingSource;
        private agencia_segurosDataSet agencia_segurosDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private agencia_segurosDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource agenciasegurosDataSetBindingSource1;
    }
}