namespace ProyectoEscritorio
{
    partial class Actividad
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
            this.lblEditarDescripcion = new System.Windows.Forms.Label();
            this.descripcionActividad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblMiembros = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.tituloActividad = new System.Windows.Forms.Label();
            this.vencimientoSelect = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tlpComentarios = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEditarDescripcion
            // 
            this.lblEditarDescripcion.AutoSize = true;
            this.lblEditarDescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditarDescripcion.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarDescripcion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEditarDescripcion.Location = new System.Drawing.Point(102, 93);
            this.lblEditarDescripcion.Name = "lblEditarDescripcion";
            this.lblEditarDescripcion.Size = new System.Drawing.Size(42, 15);
            this.lblEditarDescripcion.TabIndex = 5;
            this.lblEditarDescripcion.Text = "Editar";
            this.lblEditarDescripcion.Click += new System.EventHandler(this.lblEditarDescripcion_Click);
            // 
            // descripcionActividad
            // 
            this.descripcionActividad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.descripcionActividad.Enabled = false;
            this.descripcionActividad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionActividad.Location = new System.Drawing.Point(12, 114);
            this.descripcionActividad.MaxLength = 50;
            this.descripcionActividad.Multiline = true;
            this.descripcionActividad.Name = "descripcionActividad";
            this.descripcionActividad.Size = new System.Drawing.Size(296, 70);
            this.descripcionActividad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "-Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(17, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 11;
            this.label4.Visible = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Enabled = false;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(9, 393);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(305, 23);
            this.materialSingleLineTextField1.TabIndex = 12;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // lblMiembros
            // 
            this.lblMiembros.AutoSize = true;
            this.lblMiembros.BackColor = System.Drawing.Color.Transparent;
            this.lblMiembros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMiembros.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembros.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMiembros.Location = new System.Drawing.Point(11, 28);
            this.lblMiembros.Name = "lblMiembros";
            this.lblMiembros.Size = new System.Drawing.Size(200, 18);
            this.lblMiembros.TabIndex = 16;
            this.lblMiembros.Text = "-Ver miembros de la actividad";
            this.lblMiembros.Click += new System.EventHandler(this.lblMiembros_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.vencimientoSelect);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkEstado);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descripcionActividad);
            this.panel1.Controls.Add(this.materialSingleLineTextField1);
            this.panel1.Controls.Add(this.lblMiembros);
            this.panel1.Controls.Add(this.lblEditarDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 475);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(102, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "14 de diciembre de 2018";
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.BackColor = System.Drawing.Color.Transparent;
            this.checkEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstado.Location = new System.Drawing.Point(212, 89);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(96, 19);
            this.checkEstado.TabIndex = 43;
            this.checkEstado.Text = "Terminada";
            this.checkEstado.UseVisualStyleBackColor = false;
            this.checkEstado.CheckedChanged += new System.EventHandler(this.checkEstado_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Eliminar actividad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(11, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "-Comentarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "-Descripción";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ProyectoEscritorio.Properties.Resources.banner2;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.tituloActividad);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 35);
            this.panel2.TabIndex = 32;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Location = new System.Drawing.Point(296, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 20);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // tituloActividad
            // 
            this.tituloActividad.AutoSize = true;
            this.tituloActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tituloActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tituloActividad.ForeColor = System.Drawing.SystemColors.Control;
            this.tituloActividad.Location = new System.Drawing.Point(6, 8);
            this.tituloActividad.Name = "tituloActividad";
            this.tituloActividad.Size = new System.Drawing.Size(162, 18);
            this.tituloActividad.TabIndex = 0;
            this.tituloActividad.Text = "Nombre de actividad";
            // 
            // vencimientoSelect
            // 
            this.vencimientoSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vencimientoSelect.CustomFormat = "dd -. MMMM -. yyyy";
            this.vencimientoSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vencimientoSelect.Location = new System.Drawing.Point(271, 57);
            this.vencimientoSelect.Name = "vencimientoSelect";
            this.vencimientoSelect.Size = new System.Drawing.Size(18, 23);
            this.vencimientoSelect.TabIndex = 45;
            this.vencimientoSelect.ValueChanged += new System.EventHandler(this.vencimientoSelect_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tlpComentarios);
            this.panel3.Location = new System.Drawing.Point(12, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 195);
            this.panel3.TabIndex = 46;
            // 
            // tlpComentarios
            // 
            this.tlpComentarios.AutoScroll = true;
            this.tlpComentarios.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tlpComentarios.ColumnCount = 1;
            this.tlpComentarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComentarios.Location = new System.Drawing.Point(0, 0);
            this.tlpComentarios.Margin = new System.Windows.Forms.Padding(0);
            this.tlpComentarios.Name = "tlpComentarios";
            this.tlpComentarios.RowCount = 4;
            this.tlpComentarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComentarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComentarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComentarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpComentarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpComentarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpComentarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpComentarios.Size = new System.Drawing.Size(294, 193);
            this.tlpComentarios.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(106, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Agregar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(326, 503);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Actividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.Actividad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEditarDescripcion;
        public System.Windows.Forms.TextBox descripcionActividad;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        public System.Windows.Forms.Label lblMiembros;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label tituloActividad;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.DateTimePicker vencimientoSelect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tlpComentarios;
        private System.Windows.Forms.Label label7;
    }
}