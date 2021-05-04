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
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDataSet = new GestionSeguros.gestionDataSet();
            this.cbProv = new System.Windows.Forms.ComboBox();
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
            this.gestionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter = new GestionSeguros.gestionDataSetTableAdapters.provinciasTableAdapter();
            this.municipiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipiosTableAdapter = new GestionSeguros.gestionDataSetTableAdapters.municipiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPob
            // 
            this.cbPob.DataSource = this.municipiosBindingSource;
            this.cbPob.DisplayMember = "municipio";
            this.cbPob.FormattingEnabled = true;
            this.cbPob.Location = new System.Drawing.Point(183, 350);
            this.cbPob.Name = "cbPob";
            this.cbPob.Size = new System.Drawing.Size(121, 21);
            this.cbPob.TabIndex = 46;
            this.cbPob.ValueMember = "id";
            this.cbPob.SelectedIndexChanged += new System.EventHandler(this.cbPob_SelectedIndexChanged);
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
            // cbProv
            // 
            this.cbProv.DataSource = this.provinciasBindingSource;
            this.cbProv.DisplayMember = "provincia";
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(183, 306);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(121, 21);
            this.cbProv.TabIndex = 45;
            this.cbProv.ValueMember = "id";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(345, 349);
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
            this.tlf_txt.Location = new System.Drawing.Point(183, 245);
            this.tlf_txt.Name = "tlf_txt";
            this.tlf_txt.Size = new System.Drawing.Size(100, 20);
            this.tlf_txt.TabIndex = 36;
            // 
            // curso_txt
            // 
            this.curso_txt.Location = new System.Drawing.Point(183, 189);
            this.curso_txt.Name = "curso_txt";
            this.curso_txt.Size = new System.Drawing.Size(100, 20);
            this.curso_txt.TabIndex = 35;
            // 
            // ape_txt
            // 
            this.ape_txt.Location = new System.Drawing.Point(183, 138);
            this.ape_txt.Name = "ape_txt";
            this.ape_txt.Size = new System.Drawing.Size(100, 20);
            this.ape_txt.TabIndex = 34;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(183, 89);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 33;
            // 
            // dni_txt
            // 
            this.dni_txt.Location = new System.Drawing.Point(183, 43);
            this.dni_txt.Name = "dni_txt";
            this.dni_txt.Size = new System.Drawing.Size(100, 20);
            this.dni_txt.TabIndex = 32;
            // 
            // datosTableAdapter
            // 
            this.datosTableAdapter.ClearBeforeFill = true;
            // 
            // gestionDataSetBindingSource
            // 
            this.gestionDataSetBindingSource.DataSource = this.gestionDataSet;
            this.gestionDataSetBindingSource.Position = 0;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.gestionDataSetBindingSource;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // municipiosBindingSource
            // 
            this.municipiosBindingSource.DataMember = "municipios";
            this.municipiosBindingSource.DataSource = this.gestionDataSetBindingSource;
            // 
            // municipiosTableAdapter
            // 
            this.municipiosTableAdapter.ClearBeforeFill = true;
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 398);
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
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).EndInit();
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
    }
}