namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.prec_lbl = new System.Windows.Forms.Label();
            this.cantidad_lbl = new System.Windows.Forms.Label();
            this.iva_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.total_lbl = new System.Windows.Forms.Label();
            this.placeholder_lbl = new System.Windows.Forms.Label();
            this.prec_mask = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.cantidad_mask = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIENDA";
            // 
            // prec_lbl
            // 
            this.prec_lbl.AutoSize = true;
            this.prec_lbl.Location = new System.Drawing.Point(106, 136);
            this.prec_lbl.Name = "prec_lbl";
            this.prec_lbl.Size = new System.Drawing.Size(77, 13);
            this.prec_lbl.TabIndex = 1;
            this.prec_lbl.Text = "Precio unitario:";
            // 
            // cantidad_lbl
            // 
            this.cantidad_lbl.AutoSize = true;
            this.cantidad_lbl.Location = new System.Drawing.Point(131, 176);
            this.cantidad_lbl.Name = "cantidad_lbl";
            this.cantidad_lbl.Size = new System.Drawing.Size(52, 13);
            this.cantidad_lbl.TabIndex = 2;
            this.cantidad_lbl.Text = "Cantidad:";
            // 
            // iva_lbl
            // 
            this.iva_lbl.AutoSize = true;
            this.iva_lbl.Location = new System.Drawing.Point(153, 220);
            this.iva_lbl.Name = "iva_lbl";
            this.iva_lbl.Size = new System.Drawing.Size(27, 13);
            this.iva_lbl.TabIndex = 3;
            this.iva_lbl.Text = "IVA:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(135, 260);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(45, 13);
            this.total_lbl.TabIndex = 8;
            this.total_lbl.Text = "TOTAL:";
            // 
            // placeholder_lbl
            // 
            this.placeholder_lbl.AutoSize = true;
            this.placeholder_lbl.Location = new System.Drawing.Point(222, 260);
            this.placeholder_lbl.Name = "placeholder_lbl";
            this.placeholder_lbl.Size = new System.Drawing.Size(86, 13);
            this.placeholder_lbl.TabIndex = 9;
            this.placeholder_lbl.Text = "PLACEHOLDER";
            // 
            // prec_mask
            // 
            this.prec_mask.Location = new System.Drawing.Point(225, 136);
            this.prec_mask.Mask = "99999";
            this.prec_mask.Name = "prec_mask";
            this.prec_mask.Size = new System.Drawing.Size(100, 20);
            this.prec_mask.TabIndex = 10;
            this.prec_mask.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(225, 220);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 11;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // cantidad_mask
            // 
            this.cantidad_mask.Location = new System.Drawing.Point(225, 173);
            this.cantidad_mask.Mask = "99999";
            this.cantidad_mask.Name = "cantidad_mask";
            this.cantidad_mask.Size = new System.Drawing.Size(100, 20);
            this.cantidad_mask.TabIndex = 12;
            this.cantidad_mask.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cantidad_mask);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.prec_mask);
            this.Controls.Add(this.placeholder_lbl);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iva_lbl);
            this.Controls.Add(this.cantidad_lbl);
            this.Controls.Add(this.prec_lbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prec_lbl;
        private System.Windows.Forms.Label cantidad_lbl;
        private System.Windows.Forms.Label iva_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label placeholder_lbl;
        private System.Windows.Forms.MaskedTextBox prec_mask;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox cantidad_mask;
    }
}

