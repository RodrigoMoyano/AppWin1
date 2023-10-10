namespace ejercicios
{
    partial class PrimerApp
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
            this.btnBoton = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBoton.Enabled = false;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton.Image = global::ejercicios.Properties.Resources.foronum1545_argentina_1_peso;
            this.btnBoton.Location = new System.Drawing.Point(176, 198);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(75, 23);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Run";
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLabel.Location = new System.Drawing.Point(193, 243);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(58, 15);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Presione";
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            this.lblLabel.MouseLeave += new System.EventHandler(this.lblLabel_MouseLeave);
            this.lblLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblLabel_MouseMove);
            // 
            // txtBox
            // 
            this.txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox.Location = new System.Drawing.Point(285, 201);
            this.txtBox.MaxLength = 15000;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 2;
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(286, 239);
            this.txtNuevo.Multiline = true;
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtNuevo.TabIndex = 3;
            this.txtNuevo.Leave += new System.EventHandler(this.txtNuevo_Leave);
            // 
            // PrimerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnBoton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrimerApp";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrimerApp_FormClosed);
            this.Load += new System.EventHandler(this.PrimerApp_Load);
            this.Click += new System.EventHandler(this.btnBoton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtNuevo;
    }
}

