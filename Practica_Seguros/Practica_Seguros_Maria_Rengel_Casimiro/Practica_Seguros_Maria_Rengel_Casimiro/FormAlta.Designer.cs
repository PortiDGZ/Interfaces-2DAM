namespace Practica_Seguros_Maria_Rengel_Casimiro
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
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencia_segurosDataSet1 = new Practica_Seguros_Maria_Rengel_Casimiro.agencia_segurosDataSet1();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.cmbTiposCliente = new System.Windows.Forms.ComboBox();
            this.provinciasTableAdapter = new Practica_Seguros_Maria_Rengel_Casimiro.agencia_segurosDataSet1TableAdapters.provinciasTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCerrarAlta = new System.Windows.Forms.Label();
            this.lblAltaModificar = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.Enabled = false;
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(173, 277);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(139, 21);
            this.cmbLocalidades.TabIndex = 31;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DataSource = this.provinciasBindingSource;
            this.cmbProvincias.DisplayMember = "provincia";
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(173, 239);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(139, 21);
            this.cmbProvincias.TabIndex = 30;
            this.cmbProvincias.ValueMember = "id";
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.agencia_segurosDataSet1;
            // 
            // agencia_segurosDataSet1
            // 
            this.agencia_segurosDataSet1.DataSetName = "agencia_segurosDataSet1";
            this.agencia_segurosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(173, 203);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 20);
            this.txtTelefono.TabIndex = 28;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(173, 315);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(139, 20);
            this.txtCodPostal.TabIndex = 27;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(173, 167);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(139, 20);
            this.txtApellido.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 132);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(173, 98);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(139, 20);
            this.txtDNI.TabIndex = 24;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Enabled = false;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblLocalidad.Location = new System.Drawing.Point(27, 276);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(101, 22);
            this.lblLocalidad.TabIndex = 23;
            this.lblLocalidad.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(27, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Provincia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(27, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Teléfono";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblCP.Location = new System.Drawing.Point(27, 314);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(136, 22);
            this.lblCP.TabIndex = 20;
            this.lblCP.Text = "Código Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(27, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(27, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCliente.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblTipoCliente.Location = new System.Drawing.Point(27, 351);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(46, 22);
            this.lblTipoCliente.TabIndex = 32;
            this.lblTipoCliente.Text = "Tipo";
            // 
            // cmbTiposCliente
            // 
            this.cmbTiposCliente.FormattingEnabled = true;
            this.cmbTiposCliente.Items.AddRange(new object[] {
            "Particular",
            "Empresa"});
            this.cmbTiposCliente.Location = new System.Drawing.Point(173, 352);
            this.cmbTiposCliente.Name = "cmbTiposCliente";
            this.cmbTiposCliente.Size = new System.Drawing.Size(139, 21);
            this.cmbTiposCliente.TabIndex = 33;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.lblCerrarAlta);
            this.panel1.Controls.Add(this.lblAltaModificar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 55);
            this.panel1.TabIndex = 34;
            // 
            // lblCerrarAlta
            // 
            this.lblCerrarAlta.AutoSize = true;
            this.lblCerrarAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrarAlta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarAlta.ForeColor = System.Drawing.Color.White;
            this.lblCerrarAlta.Location = new System.Drawing.Point(344, 10);
            this.lblCerrarAlta.Name = "lblCerrarAlta";
            this.lblCerrarAlta.Size = new System.Drawing.Size(28, 28);
            this.lblCerrarAlta.TabIndex = 1;
            this.lblCerrarAlta.Text = "X";
            this.lblCerrarAlta.Click += new System.EventHandler(this.lblCerrarAlta_Click);
            // 
            // lblAltaModificar
            // 
            this.lblAltaModificar.AutoSize = true;
            this.lblAltaModificar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaModificar.ForeColor = System.Drawing.Color.White;
            this.lblAltaModificar.Location = new System.Drawing.Point(24, 12);
            this.lblAltaModificar.Name = "lblAltaModificar";
            this.lblAltaModificar.Size = new System.Drawing.Size(69, 28);
            this.lblAltaModificar.TabIndex = 0;
            this.lblAltaModificar.Text = "ALTA";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(173, 417);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 31);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 465);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTiposCliente);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.cmbLocalidades);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cmbTiposCliente;
        private agencia_segurosDataSet1 agencia_segurosDataSet1;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private agencia_segurosDataSet1TableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAltaModificar;
        private System.Windows.Forms.Label lblCerrarAlta;
        private System.Windows.Forms.Button btnAceptar;
    }
}