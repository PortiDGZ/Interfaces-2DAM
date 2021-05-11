namespace GestionSeguros
{
    partial class Alta
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
            this.cbPob = new System.Windows.Forms.ComboBox();
            this.municipiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDataSet = new GestionSeguros.gestionDataSet();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlf_txt = new System.Windows.Forms.TextBox();
            this.curso_txt = new System.Windows.Forms.TextBox();
            this.ape_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.dni_txt = new System.Windows.Forms.TextBox();
            this.datosTableAdapter = new GestionSeguros.gestionDataSetTableAdapters.datosTableAdapter();
            this.provinciasTableAdapter = new GestionSeguros.gestionDataSetTableAdapters.provinciasTableAdapter();
            this.municipiosTableAdapter = new GestionSeguros.gestionDataSetTableAdapters.municipiosTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.agencia_segurosDataSet = new GestionSeguros.agencia_segurosDataSet();
            this.provinciasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter1 = new GestionSeguros.agencia_segurosDataSetTableAdapters.provinciasTableAdapter();
            this.municipiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.municipiosTableAdapter1 = new GestionSeguros.agencia_segurosDataSetTableAdapters.municipiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPob
            // 
            this.cbPob.DataSource = this.municipiosBindingSource1;
            this.cbPob.DisplayMember = "municipio";
            this.cbPob.FormattingEnabled = true;
            this.cbPob.Location = new System.Drawing.Point(156, 350);
            this.cbPob.Name = "cbPob";
            this.cbPob.Size = new System.Drawing.Size(121, 21);
            this.cbPob.TabIndex = 46;
            this.cbPob.ValueMember = "id";
            // 
            // municipiosBindingSource
            // 
            this.municipiosBindingSource.DataMember = "municipios";
            this.municipiosBindingSource.DataSource = this.gestionDataSetBindingSource;
            // 
            // gestionDataSetBindingSource
            // 
            this.gestionDataSetBindingSource.DataSource = this.gestionDataSet;
            this.gestionDataSetBindingSource.Position = 0;
            // 
            // gestionDataSet
            // 
            this.gestionDataSet.DataSetName = "gestionDataSet";
            this.gestionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataMember = "datos";
            this.datosBindingSource.DataSource = this.gestionDataSet;
            // 
            // cbProv
            // 
            this.cbProv.DataSource = this.provinciasBindingSource1;
            this.cbProv.DisplayMember = "provincia";
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(156, 306);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(121, 21);
            this.cbProv.TabIndex = 45;
            this.cbProv.ValueMember = "id";
            this.cbProv.SelectedIndexChanged += new System.EventHandler(this.cbProv_SelectedIndexChanged);
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.gestionDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(305, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "POBLACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "PROVINCIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "CURSO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "APELLIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "DNI";
            // 
            // tlf_txt
            // 
            this.tlf_txt.Location = new System.Drawing.Point(156, 245);
            this.tlf_txt.Name = "tlf_txt";
            this.tlf_txt.Size = new System.Drawing.Size(100, 20);
            this.tlf_txt.TabIndex = 36;
            // 
            // curso_txt
            // 
            this.curso_txt.Location = new System.Drawing.Point(156, 189);
            this.curso_txt.Name = "curso_txt";
            this.curso_txt.Size = new System.Drawing.Size(100, 20);
            this.curso_txt.TabIndex = 35;
            // 
            // ape_txt
            // 
            this.ape_txt.Location = new System.Drawing.Point(156, 138);
            this.ape_txt.Name = "ape_txt";
            this.ape_txt.Size = new System.Drawing.Size(100, 20);
            this.ape_txt.TabIndex = 34;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(156, 89);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 33;
            // 
            // dni_txt
            // 
            this.dni_txt.Location = new System.Drawing.Point(156, 43);
            this.dni_txt.Name = "dni_txt";
            this.dni_txt.Size = new System.Drawing.Size(100, 20);
            this.dni_txt.TabIndex = 32;
            // 
            // datosTableAdapter
            // 
            this.datosTableAdapter.ClearBeforeFill = true;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // municipiosTableAdapter
            // 
            this.municipiosTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "CP";
            // 
            // agencia_segurosDataSet
            // 
            this.agencia_segurosDataSet.DataSetName = "agencia_segurosDataSet";
            this.agencia_segurosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasBindingSource1
            // 
            this.provinciasBindingSource1.DataMember = "provincias";
            this.provinciasBindingSource1.DataSource = this.agencia_segurosDataSet;
            // 
            // provinciasTableAdapter1
            // 
            this.provinciasTableAdapter1.ClearBeforeFill = true;
            // 
            // municipiosBindingSource1
            // 
            this.municipiosBindingSource1.DataMember = "municipios";
            this.municipiosBindingSource1.DataSource = this.agencia_segurosDataSet;
            // 
            // municipiosTableAdapter1
            // 
            this.municipiosTableAdapter1.ClearBeforeFill = true;
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 498);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbPob);
            this.Controls.Add(this.cbProv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlf_txt);
            this.Controls.Add(this.curso_txt);
            this.Controls.Add(this.ape_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.dni_txt);
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencia_segurosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbPob;
        public System.Windows.Forms.ComboBox cbProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tlf_txt;
        public System.Windows.Forms.TextBox curso_txt;
        public System.Windows.Forms.TextBox ape_txt;
        public System.Windows.Forms.TextBox name_txt;
        public System.Windows.Forms.TextBox dni_txt;
        private gestionDataSet gestionDataSet;
        private System.Windows.Forms.BindingSource datosBindingSource;
        private gestionDataSetTableAdapters.datosTableAdapter datosTableAdapter;
        private System.Windows.Forms.BindingSource gestionDataSetBindingSource;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private gestionDataSetTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.BindingSource municipiosBindingSource;
        private gestionDataSetTableAdapters.municipiosTableAdapter municipiosTableAdapter;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private agencia_segurosDataSet agencia_segurosDataSet;
        private System.Windows.Forms.BindingSource provinciasBindingSource1;
        private agencia_segurosDataSetTableAdapters.provinciasTableAdapter provinciasTableAdapter1;
        private System.Windows.Forms.BindingSource municipiosBindingSource1;
        private agencia_segurosDataSetTableAdapters.municipiosTableAdapter municipiosTableAdapter1;
    }
}