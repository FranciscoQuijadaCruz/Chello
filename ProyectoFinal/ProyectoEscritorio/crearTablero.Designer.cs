namespace ProyectoEscritorio
{
    partial class crearTablero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearTablero));
            this.btnCancelarTablero = new System.Windows.Forms.Button();
            this.txtNombreTablero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptarTablero = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarTablero
            // 
            this.btnCancelarTablero.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarTablero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarTablero.BackgroundImage")));
            this.btnCancelarTablero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarTablero.FlatAppearance.BorderSize = 0;
            this.btnCancelarTablero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTablero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTablero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarTablero.Location = new System.Drawing.Point(199, 262);
            this.btnCancelarTablero.Name = "btnCancelarTablero";
            this.btnCancelarTablero.Size = new System.Drawing.Size(127, 50);
            this.btnCancelarTablero.TabIndex = 16;
            this.btnCancelarTablero.UseVisualStyleBackColor = false;
            this.btnCancelarTablero.Click += new System.EventHandler(this.btnCancelarTablero_Click);
            // 
            // txtNombreTablero
            // 
            this.txtNombreTablero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTablero.Location = new System.Drawing.Point(33, 204);
            this.txtNombreTablero.Name = "txtNombreTablero";
            this.txtNombreTablero.Size = new System.Drawing.Size(322, 29);
            this.txtNombreTablero.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "NOMBRE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "CREAR UN TABLERO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAceptarTablero);
            this.panel1.Controls.Add(this.txtNombreTablero);
            this.panel1.Controls.Add(this.btnCancelarTablero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 337);
            this.panel1.TabIndex = 17;
            // 
            // btnAceptarTablero
            // 
            this.btnAceptarTablero.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarTablero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarTablero.FlatAppearance.BorderSize = 0;
            this.btnAceptarTablero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarTablero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarTablero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptarTablero.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarTablero.Image")));
            this.btnAceptarTablero.Location = new System.Drawing.Point(49, 262);
            this.btnAceptarTablero.Name = "btnAceptarTablero";
            this.btnAceptarTablero.Size = new System.Drawing.Size(130, 50);
            this.btnAceptarTablero.TabIndex = 15;
            this.btnAceptarTablero.UseVisualStyleBackColor = false;
            this.btnAceptarTablero.Click += new System.EventHandler(this.btnAceptarTablero_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProyectoEscritorio.Properties.Resources.banner2;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 100);
            this.panel2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Image = global::ProyectoEscritorio.Properties.Resources.chelloBan;
            this.label3.Location = new System.Drawing.Point(73, -4);
            this.label3.MinimumSize = new System.Drawing.Size(240, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 106);
            this.label3.TabIndex = 3;
            // 
            // crearTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(393, 337);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crearTablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "crearTablero";
            this.Load += new System.EventHandler(this.crearTablero_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarTablero;
        private System.Windows.Forms.TextBox txtNombreTablero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptarTablero;
    }
}