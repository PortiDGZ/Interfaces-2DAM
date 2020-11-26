namespace Factura_presu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.codigotxt = new System.Windows.Forms.MaskedTextBox();
            this.cantidadtxt = new System.Windows.Forms.MaskedTextBox();
            this.preciotxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(110, 116);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(100, 20);
            this.desctxt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(110, 63);
            this.codigotxt.Mask = "99999";
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(100, 20);
            this.codigotxt.TabIndex = 12;
            this.codigotxt.ValidatingType = typeof(int);
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Location = new System.Drawing.Point(110, 173);
            this.cantidadtxt.Mask = "99999";
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(100, 20);
            this.cantidadtxt.TabIndex = 13;
            this.cantidadtxt.ValidatingType = typeof(int);
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(110, 228);
            this.preciotxt.Mask = "99999";
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(100, 20);
            this.preciotxt.TabIndex = 14;
            this.preciotxt.ValidatingType = typeof(int);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.cantidadtxt);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox codigotxt;
        private System.Windows.Forms.MaskedTextBox cantidadtxt;
        private System.Windows.Forms.MaskedTextBox preciotxt;
    }
}