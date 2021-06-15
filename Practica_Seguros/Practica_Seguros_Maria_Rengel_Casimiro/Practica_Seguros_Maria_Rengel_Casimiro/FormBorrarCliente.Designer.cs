namespace Practica_Seguros_Maria_Rengel_Casimiro
{
    partial class FormBorrarCliente
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
            this.panelCabeceraConfirmarBorrar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConfirmarBorrar = new System.Windows.Forms.Label();
            this.lblCerrarConfirmarBorrar = new System.Windows.Forms.Label();
            this.lblMensajeConfirmarBorrar = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelCabeceraConfirmarBorrar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabeceraConfirmarBorrar
            // 
            this.panelCabeceraConfirmarBorrar.BackColor = System.Drawing.Color.DarkOrchid;
            this.panelCabeceraConfirmarBorrar.Controls.Add(this.lblCerrarConfirmarBorrar);
            this.panelCabeceraConfirmarBorrar.Controls.Add(this.lblConfirmarBorrar);
            this.panelCabeceraConfirmarBorrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeceraConfirmarBorrar.Location = new System.Drawing.Point(0, 0);
            this.panelCabeceraConfirmarBorrar.Name = "panelCabeceraConfirmarBorrar";
            this.panelCabeceraConfirmarBorrar.Size = new System.Drawing.Size(409, 46);
            this.panelCabeceraConfirmarBorrar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.lblMensajeConfirmarBorrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 179);
            this.panel1.TabIndex = 1;
            // 
            // lblConfirmarBorrar
            // 
            this.lblConfirmarBorrar.AutoSize = true;
            this.lblConfirmarBorrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarBorrar.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarBorrar.Location = new System.Drawing.Point(13, 13);
            this.lblConfirmarBorrar.Name = "lblConfirmarBorrar";
            this.lblConfirmarBorrar.Size = new System.Drawing.Size(238, 16);
            this.lblConfirmarBorrar.TabIndex = 0;
            this.lblConfirmarBorrar.Text = "Confimar eliminación de un cliente";
            // 
            // lblCerrarConfirmarBorrar
            // 
            this.lblCerrarConfirmarBorrar.AutoSize = true;
            this.lblCerrarConfirmarBorrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarConfirmarBorrar.ForeColor = System.Drawing.Color.White;
            this.lblCerrarConfirmarBorrar.Location = new System.Drawing.Point(382, 4);
            this.lblCerrarConfirmarBorrar.Name = "lblCerrarConfirmarBorrar";
            this.lblCerrarConfirmarBorrar.Size = new System.Drawing.Size(24, 25);
            this.lblCerrarConfirmarBorrar.TabIndex = 1;
            this.lblCerrarConfirmarBorrar.Text = "x";
            // 
            // lblMensajeConfirmarBorrar
            // 
            this.lblMensajeConfirmarBorrar.AutoSize = true;
            this.lblMensajeConfirmarBorrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeConfirmarBorrar.Location = new System.Drawing.Point(79, 28);
            this.lblMensajeConfirmarBorrar.Name = "lblMensajeConfirmarBorrar";
            this.lblMensajeConfirmarBorrar.Size = new System.Drawing.Size(251, 40);
            this.lblMensajeConfirmarBorrar.TabIndex = 0;
            this.lblMensajeConfirmarBorrar.Text = "Si continúa eliminará este cliente \r\nde forma definitiva";
            this.lblMensajeConfirmarBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(215)))), ((int)(((byte)(139)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(240, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "NO";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(79)))), ((int)(((byte)(117)))));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(93, 126);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "SI";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // FormBorrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 221);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCabeceraConfirmarBorrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBorrarCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBorrarCliente";
            this.panelCabeceraConfirmarBorrar.ResumeLayout(false);
            this.panelCabeceraConfirmarBorrar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabeceraConfirmarBorrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConfirmarBorrar;
        private System.Windows.Forms.Label lblCerrarConfirmarBorrar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMensajeConfirmarBorrar;
    }
}