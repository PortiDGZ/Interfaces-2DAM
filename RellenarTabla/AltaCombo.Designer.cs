namespace RellenarTabla
{
    partial class AltaCombo
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
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interfacesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interfacesDataSet1 = new RellenarTabla.interfacesDataSet1();
            this.cbPob = new System.Windows.Forms.ComboBox();
            this.provinciasTableAdapter = new RellenarTabla.interfacesDataSet1TableAdapters.provinciasTableAdapter();
            this.municipiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipiosTableAdapter = new RellenarTabla.interfacesDataSet1TableAdapters.municipiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(500, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "POBLACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "PROVINCIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "CURSO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "APELLIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "DNI";
            // 
            // tlf_txt
            // 
            this.tlf_txt.Location = new System.Drawing.Point(338, 263);
            this.tlf_txt.Name = "tlf_txt";
            this.tlf_txt.Size = new System.Drawing.Size(100, 20);
            this.tlf_txt.TabIndex = 19;
            // 
            // curso_txt
            // 
            this.curso_txt.Location = new System.Drawing.Point(338, 207);
            this.curso_txt.Name = "curso_txt";
            this.curso_txt.Size = new System.Drawing.Size(100, 20);
            this.curso_txt.TabIndex = 18;
            // 
            // ape_txt
            // 
            this.ape_txt.Location = new System.Drawing.Point(338, 156);
            this.ape_txt.Name = "ape_txt";
            this.ape_txt.Size = new System.Drawing.Size(100, 20);
            this.ape_txt.TabIndex = 17;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(338, 107);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 16;
            // 
            // dni_txt
            // 
            this.dni_txt.Location = new System.Drawing.Point(338, 61);
            this.dni_txt.Name = "dni_txt";
            this.dni_txt.Size = new System.Drawing.Size(100, 20);
            this.dni_txt.TabIndex = 15;
            // 
            // cbProv
            // 
            this.cbProv.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.provinciasBindingSource, "id", true));
            this.cbProv.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.provinciasBindingSource, "provincia", true));
            this.cbProv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provinciasBindingSource, "provincia", true));
            this.cbProv.DataSource = this.provinciasBindingSource;
            this.cbProv.DisplayMember = "provincia";
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(338, 324);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(121, 21);
            this.cbProv.TabIndex = 30;
            this.cbProv.ValueMember = "id";
            this.cbProv.SelectedIndexChanged += new System.EventHandler(this.cbProv_SelectedIndexChanged);
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.interfacesDataSet1BindingSource;
            // 
            // interfacesDataSet1BindingSource
            // 
            this.interfacesDataSet1BindingSource.DataSource = this.interfacesDataSet1;
            this.interfacesDataSet1BindingSource.Position = 0;
            // 
            // interfacesDataSet1
            // 
            this.interfacesDataSet1.DataSetName = "interfacesDataSet1";
            this.interfacesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbPob
            // 
            this.cbPob.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.municipiosBindingSource, "municipio", true));
            this.cbPob.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.municipiosBindingSource, "id", true));
            this.cbPob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.municipiosBindingSource, "municipio", true));
            this.cbPob.DataSource = this.municipiosBindingSource;
            this.cbPob.DisplayMember = "municipio";
            this.cbPob.FormattingEnabled = true;
            this.cbPob.Location = new System.Drawing.Point(338, 368);
            this.cbPob.Name = "cbPob";
            this.cbPob.Size = new System.Drawing.Size(121, 21);
            this.cbPob.TabIndex = 31;
            this.cbPob.ValueMember = "id";
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // municipiosBindingSource
            // 
            this.municipiosBindingSource.DataMember = "municipios";
            this.municipiosBindingSource.DataSource = this.interfacesDataSet1BindingSource;
            // 
            // municipiosTableAdapter
            // 
            this.municipiosTableAdapter.ClearBeforeFill = true;
            // 
            // AltaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "AltaCombo";
            this.Text = "AltaCombo";
            this.Load += new System.EventHandler(this.AltaCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private interfacesDataSet1 interfacesDataSet1;
        private System.Windows.Forms.BindingSource interfacesDataSet1BindingSource;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private interfacesDataSet1TableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.BindingSource municipiosBindingSource;
        private interfacesDataSet1TableAdapters.municipiosTableAdapter municipiosTableAdapter;
        public System.Windows.Forms.ComboBox cbProv;
        public System.Windows.Forms.ComboBox cbPob;
    }
}