namespace EjercicioDatGrid
{
    partial class FormAlta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.cmbPoblaciones = new System.Windows.Forms.ComboBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.agencia_segurosDataSet1 = new EjercicioDatGrid.agencia_segurosDataSet1();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter = new EjercicioDatGrid.agencia_segurosDataSet1TableAdapters.provinciasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Provincia";
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.Enabled = false;
            this.lblPoblacion.Location = new System.Drawing.Point(22, 264);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(54, 13);
            this.lblPoblacion.TabIndex = 6;
            this.lblPoblacion.Text = "Población";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(114, 42);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(139, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(114, 111);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(139, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(114, 149);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(139, 20);
            this.txtCp.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(114, 185);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(114, 394);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DataSource = this.provinciasBindingSource;
            this.cmbProvincias.DisplayMember = "provincia";
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(114, 223);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(139, 21);
            this.cmbProvincias.TabIndex = 15;
            this.cmbProvincias.ValueMember = "id";
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // cmbPoblaciones
            // 
            this.cmbPoblaciones.FormattingEnabled = true;
            this.cmbPoblaciones.Location = new System.Drawing.Point(114, 261);
            this.cmbPoblaciones.Name = "cmbPoblaciones";
            this.cmbPoblaciones.Size = new System.Drawing.Size(139, 21);
            this.cmbPoblaciones.TabIndex = 16;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Empresa",
            "Particular"});
            this.cmb_tipo.Location = new System.Drawing.Point(114, 300);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(139, 21);
            this.cmb_tipo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(45, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo";
            // 
            // agencia_segurosDataSet1
            // 
            this.agencia_segurosDataSet1.DataSetName = "agencia_segurosDataSet1";
            this.agencia_segurosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.agencia_segurosDataSet1;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 468);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.cmbPoblaciones);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlta";
            this.Text = "Alta/Modificar";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.ComboBox cmbPoblaciones;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label7;
        private agencia_segurosDataSet1 agencia_segurosDataSet1;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private agencia_segurosDataSet1TableAdapters.provinciasTableAdapter provinciasTableAdapter;
    }
}