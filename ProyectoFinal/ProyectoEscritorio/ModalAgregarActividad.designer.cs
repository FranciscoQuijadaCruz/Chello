namespace ProyectoEscritorio
{
    partial class ModalAgregarActividad
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
            this.nombreModulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregarModulo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreModulo
            // 
            this.nombreModulo.Depth = 0;
            this.nombreModulo.Hint = "";
            this.nombreModulo.Location = new System.Drawing.Point(14, 77);
            this.nombreModulo.MaxLength = 32767;
            this.nombreModulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreModulo.Name = "nombreModulo";
            this.nombreModulo.PasswordChar = '\0';
            this.nombreModulo.SelectedText = "";
            this.nombreModulo.SelectionLength = 0;
            this.nombreModulo.SelectionStart = 0;
            this.nombreModulo.Size = new System.Drawing.Size(163, 23);
            this.nombreModulo.TabIndex = 2;
            this.nombreModulo.TabStop = false;
            this.nombreModulo.UseSystemPasswordChar = false;
            // 
            // btnAgregarModulo
            // 
            this.btnAgregarModulo.AutoSize = true;
            this.btnAgregarModulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarModulo.Depth = 0;
            this.btnAgregarModulo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarModulo.Icon = null;
            this.btnAgregarModulo.Location = new System.Drawing.Point(14, 122);
            this.btnAgregarModulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarModulo.Name = "btnAgregarModulo";
            this.btnAgregarModulo.Primary = true;
            this.btnAgregarModulo.Size = new System.Drawing.Size(82, 36);
            this.btnAgregarModulo.TabIndex = 4;
            this.btnAgregarModulo.Text = "Aceptar";
            this.btnAgregarModulo.UseVisualStyleBackColor = true;
            this.btnAgregarModulo.Click += new System.EventHandler(this.btnAgregarModulo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nombreModulo);
            this.panel1.Controls.Add(this.btnAgregarModulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 172);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BackgroundImage = global::ProyectoEscritorio.Properties.Resources.banner2;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 35);
            this.panel2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar actividad";
            // 
            // ModalAgregarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 172);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalAgregarActividad";
            this.Text = "ModalAgregarActividad";
            this.Load += new System.EventHandler(this.ModalAgregarActividad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialSingleLineTextField nombreModulo;
        public MaterialSkin.Controls.MaterialRaisedButton btnAgregarModulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}