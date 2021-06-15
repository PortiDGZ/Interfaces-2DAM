namespace Practica_Seguros_Maria_Rengel_Casimiro
{
    partial class FormGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestion));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencia_segurosDataSet = new Practica_Seguros_Maria_Rengel_Casimiro.agencia_segurosDataSet();
            this.clienteTableAdapter = new Practica_Seguros_Maria_Rengel_Casimiro.agencia_segurosDataSetTableAdapters.clienteTableAdapter();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.PictureBox();
            this.btnBaja = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picBuscador = new System.Windows.Forms.PictureBox();
            this.btn_report = new System.Windows.Forms.Button();
            this.btnVerPolizas = new System.Windows.Forms.Button();
            this.report = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 7, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(34, 178);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(819, 252);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.agencia_segurosDataSet;
            // 
            // agencia_segurosDataSet
            // 
            this.agencia_segurosDataSet.DataSetName = "agencia_segurosDataSet";
            this.agencia_segurosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblCerrar.Location = new System.Drawing.Point(848, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(25, 30);
            this.lblCerrar.TabIndex = 10;
            this.lblCerrar.Text = "x";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.Image = ((System.Drawing.Image)(resources.GetObject("btnAlta.Image")));
            this.btnAlta.Location = new System.Drawing.Point(34, 116);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(35, 35);
            this.btnAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAlta.TabIndex = 11;
            this.btnAlta.TabStop = false;
            this.btnAlta.Tag = "";
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaja.Enabled = false;
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.Location = new System.Drawing.Point(151, 116);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(35, 35);
            this.btnBaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBaja.TabIndex = 12;
            this.btnBaja.TabStop = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(93, 116);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(35, 35);
            this.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificar.TabIndex = 13;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscador.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBuscador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscador.HintForeColor = System.Drawing.Color.Empty;
            this.txtBuscador.HintText = "";
            this.txtBuscador.isPassword = false;
            this.txtBuscador.LineFocusedColor = System.Drawing.Color.DarkOrchid;
            this.txtBuscador.LineIdleColor = System.Drawing.Color.DarkOrchid;
            this.txtBuscador.LineMouseHoverColor = System.Drawing.Color.DarkOrchid;
            this.txtBuscador.LineThickness = 3;
            this.txtBuscador.Location = new System.Drawing.Point(653, 119);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(200, 32);
            this.txtBuscador.TabIndex = 14;
            this.txtBuscador.Tag = "";
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscador.OnValueChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // picBuscador
            // 
            this.picBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscador.Enabled = false;
            this.picBuscador.Image = ((System.Drawing.Image)(resources.GetObject("picBuscador.Image")));
            this.picBuscador.Location = new System.Drawing.Point(610, 116);
            this.picBuscador.Name = "picBuscador";
            this.picBuscador.Size = new System.Drawing.Size(35, 35);
            this.picBuscador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuscador.TabIndex = 15;
            this.picBuscador.TabStop = false;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(316, 44);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 23);
            this.btn_report.TabIndex = 16;
            this.btn_report.Text = "button1";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerPolizas
            // 
            this.btnVerPolizas.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnVerPolizas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPolizas.FlatAppearance.BorderSize = 0;
            this.btnVerPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPolizas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPolizas.ForeColor = System.Drawing.Color.White;
            this.btnVerPolizas.Location = new System.Drawing.Point(34, 453);
            this.btnVerPolizas.Name = "btnVerPolizas";
            this.btnVerPolizas.Size = new System.Drawing.Size(152, 28);
            this.btnVerPolizas.TabIndex = 17;
            this.btnVerPolizas.Text = "VER POLIZAS";
            this.btnVerPolizas.UseVisualStyleBackColor = false;
            this.btnVerPolizas.Click += new System.EventHandler(this.btnVerPolizas_Click);
            // 
            // report
            // 
            this.report.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.report.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.report.HintForeColor = System.Drawing.Color.Empty;
            this.report.HintText = "";
            this.report.isPassword = false;
            this.report.LineFocusedColor = System.Drawing.Color.DarkOrchid;
            this.report.LineIdleColor = System.Drawing.Color.DarkOrchid;
            this.report.LineMouseHoverColor = System.Drawing.Color.DarkOrchid;
            this.report.LineThickness = 3;
            this.report.Location = new System.Drawing.Point(413, 35);
            this.report.Margin = new System.Windows.Forms.Padding(4);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(200, 32);
            this.report.TabIndex = 18;
            this.report.Tag = "";
            this.report.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 500);
            this.Controls.Add(this.report);
            this.Controls.Add(this.btnVerPolizas);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.picBuscador);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestion";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private agencia_segurosDataSet agencia_segurosDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private agencia_segurosDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.PictureBox btnAlta;
        private System.Windows.Forms.PictureBox btnBaja;
        private System.Windows.Forms.PictureBox btnModificar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscador;
        private System.Windows.Forms.PictureBox picBuscador;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btnVerPolizas;
        private Bunifu.Framework.UI.BunifuMaterialTextbox report;
    }
}