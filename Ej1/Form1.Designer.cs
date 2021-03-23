namespace Ej1
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
            this.num_txt = new System.Windows.Forms.Label();
            this.help_txt = new System.Windows.Forms.Label();
            this.placeholder_txt = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.play_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.entrada_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_txt
            // 
            this.num_txt.AutoSize = true;
            this.num_txt.Location = new System.Drawing.Point(307, 108);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(44, 13);
            this.num_txt.TabIndex = 0;
            this.num_txt.Text = "Número";
            // 
            // help_txt
            // 
            this.help_txt.AutoSize = true;
            this.help_txt.Location = new System.Drawing.Point(214, 185);
            this.help_txt.Name = "help_txt";
            this.help_txt.Size = new System.Drawing.Size(37, 13);
            this.help_txt.TabIndex = 1;
            this.help_txt.Text = "Ayuda";
            // 
            // placeholder_txt
            // 
            this.placeholder_txt.AutoSize = true;
            this.placeholder_txt.Location = new System.Drawing.Point(257, 185);
            this.placeholder_txt.Name = "placeholder_txt";
            this.placeholder_txt.Size = new System.Drawing.Size(63, 13);
            this.placeholder_txt.TabIndex = 2;
            this.placeholder_txt.Text = "Placeholder";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(357, 105);
            this.maskedTextBox1.Mask = "99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // play_btn
            // 
            this.play_btn.Location = new System.Drawing.Point(342, 359);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(115, 43);
            this.play_btn.TabIndex = 4;
            this.play_btn.Text = "Jugar";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adivinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entrada_btn
            // 
            this.entrada_btn.Location = new System.Drawing.Point(57, 100);
            this.entrada_btn.Name = "entrada_btn";
            this.entrada_btn.Size = new System.Drawing.Size(115, 21);
            this.entrada_btn.TabIndex = 6;
            this.entrada_btn.Text = "Entrada Manual";
            this.entrada_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entrada_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.placeholder_txt);
            this.Controls.Add(this.help_txt);
            this.Controls.Add(this.num_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_txt;
        private System.Windows.Forms.Label help_txt;
        private System.Windows.Forms.Label placeholder_txt;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button entrada_btn;
    }
}

