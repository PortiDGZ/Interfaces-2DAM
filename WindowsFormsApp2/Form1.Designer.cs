namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.Label();
            this.subtitulo = new System.Windows.Forms.Label();
            this.num1_txt = new System.Windows.Forms.MaskedTextBox();
            this.num3_txt = new System.Windows.Forms.MaskedTextBox();
            this.num2_txt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_all = new System.Windows.Forms.RadioButton();
            this.rad_div = new System.Windows.Forms.RadioButton();
            this.rad_mult = new System.Windows.Forms.RadioButton();
            this.rad_restar = new System.Windows.Forms.RadioButton();
            this.rad_sumar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.placeholder_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(304, 48);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(199, 25);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Sumar Tres Números";
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitulo.Location = new System.Drawing.Point(330, 108);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(146, 17);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Ingrese tres números:";
            // 
            // num1_txt
            // 
            this.num1_txt.Location = new System.Drawing.Point(255, 159);
            this.num1_txt.Mask = "99999";
            this.num1_txt.Name = "num1_txt";
            this.num1_txt.Size = new System.Drawing.Size(100, 20);
            this.num1_txt.TabIndex = 2;
            this.num1_txt.ValidatingType = typeof(int);
            // 
            // num3_txt
            // 
            this.num3_txt.Location = new System.Drawing.Point(492, 159);
            this.num3_txt.Mask = "99999";
            this.num3_txt.Name = "num3_txt";
            this.num3_txt.Size = new System.Drawing.Size(100, 20);
            this.num3_txt.TabIndex = 3;
            this.num3_txt.ValidatingType = typeof(int);
            // 
            // num2_txt
            // 
            this.num2_txt.Location = new System.Drawing.Point(376, 159);
            this.num2_txt.Mask = "99999";
            this.num2_txt.Name = "num2_txt";
            this.num2_txt.Size = new System.Drawing.Size(100, 20);
            this.num2_txt.TabIndex = 4;
            this.num2_txt.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_all);
            this.groupBox1.Controls.Add(this.rad_div);
            this.groupBox1.Controls.Add(this.rad_mult);
            this.groupBox1.Controls.Add(this.rad_restar);
            this.groupBox1.Controls.Add(this.rad_sumar);
            this.groupBox1.Location = new System.Drawing.Point(30, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rad_all
            // 
            this.rad_all.AutoSize = true;
            this.rad_all.Location = new System.Drawing.Point(38, 163);
            this.rad_all.Name = "rad_all";
            this.rad_all.Size = new System.Drawing.Size(55, 17);
            this.rad_all.TabIndex = 10;
            this.rad_all.TabStop = true;
            this.rad_all.Text = "Todas";
            this.rad_all.UseVisualStyleBackColor = true;
            // 
            // rad_div
            // 
            this.rad_div.AutoSize = true;
            this.rad_div.Location = new System.Drawing.Point(38, 128);
            this.rad_div.Name = "rad_div";
            this.rad_div.Size = new System.Drawing.Size(54, 17);
            this.rad_div.TabIndex = 9;
            this.rad_div.TabStop = true;
            this.rad_div.Text = "Dividir";
            this.rad_div.UseVisualStyleBackColor = true;
            // 
            // rad_mult
            // 
            this.rad_mult.AutoSize = true;
            this.rad_mult.Location = new System.Drawing.Point(37, 93);
            this.rad_mult.Name = "rad_mult";
            this.rad_mult.Size = new System.Drawing.Size(72, 17);
            this.rad_mult.TabIndex = 8;
            this.rad_mult.TabStop = true;
            this.rad_mult.Text = "Multiplicar";
            this.rad_mult.UseVisualStyleBackColor = true;
            // 
            // rad_restar
            // 
            this.rad_restar.AutoSize = true;
            this.rad_restar.Location = new System.Drawing.Point(37, 59);
            this.rad_restar.Name = "rad_restar";
            this.rad_restar.Size = new System.Drawing.Size(56, 17);
            this.rad_restar.TabIndex = 7;
            this.rad_restar.TabStop = true;
            this.rad_restar.Text = "Restar";
            this.rad_restar.UseVisualStyleBackColor = true;
            // 
            // rad_sumar
            // 
            this.rad_sumar.AutoSize = true;
            this.rad_sumar.Location = new System.Drawing.Point(37, 24);
            this.rad_sumar.Name = "rad_sumar";
            this.rad_sumar.Size = new System.Drawing.Size(55, 17);
            this.rad_sumar.TabIndex = 6;
            this.rad_sumar.TabStop = true;
            this.rad_sumar.Text = "Sumar";
            this.rad_sumar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Los resultados son:";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(228, 385);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 23);
            this.confirm_btn.TabIndex = 7;
            this.confirm_btn.Text = "Aceptar";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(355, 385);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "Borrar";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(492, 385);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "Salir";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // placeholder_lbl
            // 
            this.placeholder_lbl.AutoSize = true;
            this.placeholder_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder_lbl.Location = new System.Drawing.Point(394, 214);
            this.placeholder_lbl.Name = "placeholder_lbl";
            this.placeholder_lbl.Size = new System.Drawing.Size(0, 17);
            this.placeholder_lbl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.placeholder_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.num2_txt);
            this.Controls.Add(this.num3_txt);
            this.Controls.Add(this.num1_txt);
            this.Controls.Add(this.subtitulo);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label subtitulo;
        private System.Windows.Forms.MaskedTextBox num1_txt;
        private System.Windows.Forms.MaskedTextBox num3_txt;
        private System.Windows.Forms.MaskedTextBox num2_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_all;
        private System.Windows.Forms.RadioButton rad_div;
        private System.Windows.Forms.RadioButton rad_mult;
        private System.Windows.Forms.RadioButton rad_restar;
        private System.Windows.Forms.RadioButton rad_sumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label placeholder_lbl;
    }
}

