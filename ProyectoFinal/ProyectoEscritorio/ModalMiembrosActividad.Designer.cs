namespace ProyectoEscritorio
{
    partial class ModalMiembrosActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalMiembrosActividad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.tituloActividad = new System.Windows.Forms.Label();
            this.pnMiembros = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 308);
            this.panel1.TabIndex = 32;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(3, 275);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(221, 28);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Agregar miembro";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.tituloActividad);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 35);
            this.panel2.TabIndex = 33;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(202, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 20);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tituloActividad
            // 
            this.tituloActividad.AutoSize = true;
            this.tituloActividad.BackColor = System.Drawing.Color.Transparent;
            this.tituloActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tituloActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tituloActividad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloActividad.Location = new System.Drawing.Point(3, 9);
            this.tituloActividad.Name = "tituloActividad";
            this.tituloActividad.Size = new System.Drawing.Size(83, 18);
            this.tituloActividad.TabIndex = 0;
            this.tituloActividad.Text = "Miembros";
            // 
            // pnMiembros
            // 
            this.pnMiembros.AllowDrop = true;
            this.pnMiembros.AutoScroll = true;
            this.pnMiembros.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnMiembros.ColumnCount = 1;
            this.pnMiembros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnMiembros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnMiembros.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnMiembros.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnMiembros.Location = new System.Drawing.Point(4, 40);
            this.pnMiembros.Name = "pnMiembros";
            this.pnMiembros.RowCount = 6;
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnMiembros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnMiembros.Size = new System.Drawing.Size(221, 228);
            this.pnMiembros.TabIndex = 47;
            this.pnMiembros.TabStop = true;
            // 
            // ModalMiembrosActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 308);
            this.Controls.Add(this.pnMiembros);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalMiembrosActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalMiembrosActividad";
            this.Load += new System.EventHandler(this.ModalMiembrosActividad_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label tituloActividad;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TableLayoutPanel pnMiembros;
    }
}